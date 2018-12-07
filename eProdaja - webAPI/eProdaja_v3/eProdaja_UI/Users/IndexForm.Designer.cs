namespace eProdaja_UI.Users
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noviKorisnikButton = new System.Windows.Forms.Button();
            this.traziButton = new System.Windows.Forms.Button();
            this.izmijeniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(90, 31);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(317, 20);
            this.imePrezimeInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime i prezime:";
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.AllowUserToAddRows = false;
            this.korisniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.KorisnickoIme,
            this.Status});
            this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciGrid.Location = new System.Drawing.Point(0, 79);
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.ReadOnly = true;
            this.korisniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciGrid.Size = new System.Drawing.Size(917, 558);
            this.korisniciGrid.TabIndex = 3;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Aktivan";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // noviKorisnikButton
            // 
            this.noviKorisnikButton.Location = new System.Drawing.Point(708, 29);
            this.noviKorisnikButton.Name = "noviKorisnikButton";
            this.noviKorisnikButton.Size = new System.Drawing.Size(98, 23);
            this.noviKorisnikButton.TabIndex = 4;
            this.noviKorisnikButton.Text = "Novi korisnik";
            this.noviKorisnikButton.UseVisualStyleBackColor = true;
            this.noviKorisnikButton.Click += new System.EventHandler(this.noviKorisnikButton_Click);
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(413, 29);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 5;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // izmijeniButton
            // 
            this.izmijeniButton.Location = new System.Drawing.Point(812, 29);
            this.izmijeniButton.Name = "izmijeniButton";
            this.izmijeniButton.Size = new System.Drawing.Size(98, 23);
            this.izmijeniButton.TabIndex = 6;
            this.izmijeniButton.Text = "Izmijeni korisnika";
            this.izmijeniButton.UseVisualStyleBackColor = true;
            this.izmijeniButton.Click += new System.EventHandler(this.izmijeniButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 637);
            this.Controls.Add(this.izmijeniButton);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.noviKorisnikButton);
            this.Controls.Add(this.korisniciGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imePrezimeInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija korisnika";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.Button noviKorisnikButton;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Button izmijeniButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}