using eProdaja_API.Models;
using eProdaja_UI.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Windows.Forms;

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
            {
                k = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Korisnici>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            this.AutoValidate = AutoValidate.Disable;
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

                for (int i = 0; i < ulogeList.Items.Count; i++)
                {
                    var xyz = ulogeList.Items[i];

                    if (k.KorisniciUloge.Where(x => x.Uloge.Naziv == (xyz as Uloge).Naziv).Count() != 0)
                    {
                        ulogeList.SetItemChecked(i, true);
                    }
                }

            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
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
                        k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text);
                    }

                    k.Status = statusCheckBox.Checked;


                    k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();
                    k.UlogeForDelete = new List<KorisniciUloge>();
                    for (int i = 0; i < k.Uloge.Count; i++)
                    {
                        if (k.KorisniciUloge.FirstOrDefault(y => y.UlogaID == k.Uloge[i].UlogaID) != null)
                        {
                            k.Uloge.Remove(k.Uloge[i]);
                        }

                    }

                    foreach (var x in k.KorisniciUloge)
                    {
                        if (k.Uloge.FirstOrDefault(y => y.UlogaID == x.UlogaID) == null)
                        {
                            k.UlogeForDelete.Add(x);
                        }
                    }

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

        private void imeInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (imeInput.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Messages.ime_req);
            }
        }

        private void prezimeInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (prezimeInput.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Messages.prezime_req);
            }
        }

        private void emailInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool ModelStateIsValid = true;
            if (emailInput.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, "Email obavezan");
                ModelStateIsValid = false;
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Messages.email_format_req);
                    ModelStateIsValid = false;

                }

            }

            if (ModelStateIsValid)
            {
                errorProvider.SetError(emailInput, "");
            }
        }

        private void korisnickoImeInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (korisnickoImeInput.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.username_req);
            }
        }

        private void lozinkaInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lozinkaInput.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.lozinka_req);
            }
            else if (lozinkaInput.Text.Length < 6)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.lozinka_str_len);
            }
            else if (!lozinkaInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.loznika_num_req);
            }

        }

    }
}