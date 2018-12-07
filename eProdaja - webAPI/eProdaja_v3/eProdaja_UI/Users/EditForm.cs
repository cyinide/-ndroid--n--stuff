using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eProdaja_API.Models;
using eProdaja_UI.Util;
using System.Net.Http;
using System.Resources;
using System.Configuration;

namespace eProdaja_UI.Users
{
    public partial class EditForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);
        private Korisnici k { get; set; }

        public EditForm(int korisnikId)
        {
            InitializeComponent();

            HttpResponseMessage response = korisniciService.GetResponse(korisnikId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                k = null;
            else if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Korisnici>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            imeInput.Text = k.Ime;
            prezimeInput.Text = k.Prezime;
            telefonInput.Text = k.Telefon;
            emailInput.Text = k.Email;
            korisnickoImeInput.Text = k.KorisnickoIme;
            statusCheckBox.Checked = k.Status;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ulogeList.DisplayMember = "Naziv";
                ulogeList.ClearSelected();
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Telefon = telefonInput.Text;
                k.Email = emailInput.Text;

                k.KorisnickoIme = korisnickoImeInput.Text;

                if (lozinkaInput.Text != String.Empty)
                {
                    k.LozinkaSalt = UIHelper.GenerateSalt();
                    k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                }

                k.Status = statusCheckBox.Checked;
                
                HttpResponseMessage response = korisniciService.PutResponse(k.KorisnikID, k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

    }
}
