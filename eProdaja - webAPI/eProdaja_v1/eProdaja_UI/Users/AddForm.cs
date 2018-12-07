using eProdaja_API.Models;
using eProdaja_UI.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace eProdaja_UI.Users
{
    public partial class AddForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

        public AddForm()
        {
            InitializeComponent();
        }


        private void AddForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ulogeList.DisplayMember = "Naziv";
                ulogeList.ClearSelected();
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Korisnici k = new Korisnici();
            k.Ime = imeInput.Text;
            k.Prezime = prezimeInput.Text;
            k.Email = emailInput.Text;

            k.KorisnickoIme = korisnickoImeInput.Text;
            k.LozinkaSalt = UIHelper.GenerateSalt();
            k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text);
            k.Status = true;

            k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

            HttpResponseMessage response = korisniciService.PostResponse(k);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.add_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                string msg = response.ReasonPhrase;
                if (Messages.ResourceManager.GetString(response.ReasonPhrase) != String.Empty)
                {
                    msg = Messages.ResourceManager.GetString(response.ReasonPhrase);
                }

                MessageBox.Show("Error Code " + response.StatusCode + ": Error Message - " + msg);
            }
        }
    }
}
