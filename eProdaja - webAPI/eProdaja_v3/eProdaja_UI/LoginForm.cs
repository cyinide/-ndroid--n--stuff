using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eProdaja_UI.Util;
using eProdaja_API.Models;
using System.Net.Http;
using System.Resources;
using System.Configuration;

namespace eProdaja_UI
{
    public partial class LoginForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Prijava()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("GetByUsername", korisnickoImeInput.Text);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                MessageBox.Show(Messages.login_user_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;

                if (UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text) == k.LozinkaHash)
                {
                    this.DialogResult = DialogResult.OK;
                    Global.prijavljeniKorisnik = k;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Messages.login_pass_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lozinkaInput.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " Message - " + response.ReasonPhrase);
            }
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lozinkaInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Prijava();
        }
    }
}
