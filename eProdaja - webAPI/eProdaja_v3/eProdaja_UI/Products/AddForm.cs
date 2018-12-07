using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;
using eProdaja_UI.Util;


namespace eProdaja_UI.Products
{
    public partial class AddForm : Form
    {
        private WebAPIHelper proizvodiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProizvodiRoute);
        private WebAPIHelper vrsteService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.VrsteProizvodaRoute);
        private WebAPIHelper jedMjereService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.JediniceMjereRoute);

        private Proizvodi proizvod = new Proizvodi();

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindVrsteProizvoda();
            BindJediniceMjere();
        }

        #region Bindings
        private void BindVrsteProizvoda()
        {
            HttpResponseMessage response = vrsteService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = response.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());

                vrsteProizvodaList.DataSource = vrste;
                vrsteProizvodaList.DisplayMember = "Naziv";
                vrsteProizvodaList.ValueMember = "VrstaID";
            }
        }

        private void BindJediniceMjere()
        {
            HttpResponseMessage response = jedMjereService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<JediniceMjere> jedinice = response.Content.ReadAsAsync<List<JediniceMjere>>().Result;
                jedinice.Insert(0, new JediniceMjere());

                jediniceMjereList.DataSource = jedinice;
                jediniceMjereList.DisplayMember = "Naziv";
                jediniceMjereList.ValueMember = "JedinicaMjereID";
            }
        }

        private void BindGrid()
        {
            HttpResponseMessage response = proizvodiService.GetActionResponse("SearchByVrsta", vrsteProizvodaList.SelectedValue.ToString());

            if (response.IsSuccessStatusCode)
            {
                proizvodiGrid.DataSource = response.Content.ReadAsAsync<List<Proizvodi_Result>>().Result;
                proizvodiGrid.Columns[0].Visible = false;

            }
        }

        #endregion

        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                proizvod.Slika = File.ReadAllBytes(slikaInput.Text);
                Image orgImage = Image.FromFile(slikaInput.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (orgImage.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImgWidth, resizedImgHeight));

                    if (resizedImg.Width > croppedImgWidth && resizedImg.Height > croppedImgHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;

                        Image croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        pictureBox.Image = croppedImg;

                        MemoryStream ms = new MemoryStream();
                        croppedImg.Save(ms, orgImage.RawFormat);

                        proizvod.SlikaThumb = ms.ToArray();

                    }
                    else
                    {
                        MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        proizvod = null;
                    }
                }
            }
            catch (Exception)
            {
                proizvod.Slika = null;
                proizvod.SlikaThumb = null;
                slikaInput.Text = null;
                pictureBox.Image = null;
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (proizvod == null)
                    proizvod = new Proizvodi();

                if (vrsteProizvodaList.SelectedIndex != 0)
                    proizvod.VrstaID = Convert.ToInt32(vrsteProizvodaList.SelectedValue);

                proizvod.Sifra = sifraInput.Text;
                proizvod.Naziv = nazivInput.Text;

                proizvod.Cijena = Convert.ToDecimal(cijenaInput.Text);

                if (jediniceMjereList.SelectedIndex != 0)
                    proizvod.JedinicaMjereID = Convert.ToInt32(jediniceMjereList.SelectedValue);

                HttpResponseMessage response = proizvodiService.PostResponse(proizvod);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_product_succ, Messages.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                    Clear();
                }
                else
                    MessageBox.Show(response.ReasonPhrase, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            sifraInput.Text = "";
            nazivInput.Text = "";
            cijenaInput.Text = "";
            jediniceMjereList.SelectedIndex = 0;
            slikaInput.Text = "";
            pictureBox.Image = null;
        }

        private void vrsteProizvodaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

      
    }
}
