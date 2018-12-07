using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eProdaja_UI.Util;
using eProdaja_API.Models;
using System.Configuration;

namespace eProdaja_UI.Users
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);

        public IndexForm()
        {
            InitializeComponent();
            korisniciGrid.AutoGenerateColumns = false;
        }
        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
           HttpResponseMessage response = korisniciService.GetActionResponse("SearchByName", imePrezimeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> korisnici = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                korisniciGrid.DataSource = korisnici;
                korisniciGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void izmijeniButton_Click(object sender, EventArgs e)
        {
            EditForm frm = new EditForm(Convert.ToInt32(korisniciGrid.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
            BindGrid();
        }

        private void noviKorisnikButton_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.ShowDialog();
            BindGrid();
        }

       
    }
}
