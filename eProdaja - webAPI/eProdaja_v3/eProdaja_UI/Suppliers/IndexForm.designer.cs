namespace eProdaja_UI.Suppliers
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
            this.label2 = new System.Windows.Forms.Label();
            this.dobavljaciGrid = new System.Windows.Forms.DataGridView();
            this.DobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.traziButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "*Dvostrukim klikom odaberite dobavljača.";
            // 
            // dobavljaciGrid
            // 
            this.dobavljaciGrid.AllowUserToAddRows = false;
            this.dobavljaciGrid.AllowUserToDeleteRows = false;
            this.dobavljaciGrid.AllowUserToOrderColumns = true;
            this.dobavljaciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dobavljaciGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dobavljaciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dobavljaciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DobavljacID,
            this.Naziv,
            this.Adresa,
            this.Telefon,
            this.KontaktOsoba,
            this.Email});
            this.dobavljaciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dobavljaciGrid.Location = new System.Drawing.Point(0, 92);
            this.dobavljaciGrid.MultiSelect = false;
            this.dobavljaciGrid.Name = "dobavljaciGrid";
            this.dobavljaciGrid.ReadOnly = true;
            this.dobavljaciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dobavljaciGrid.Size = new System.Drawing.Size(628, 225);
            this.dobavljaciGrid.TabIndex = 10;
            // 
            // DobavljacID
            // 
            this.DobavljacID.DataPropertyName = "DobavljacID";
            this.DobavljacID.HeaderText = "DobavljacID";
            this.DobavljacID.Name = "DobavljacID";
            this.DobavljacID.ReadOnly = true;
            this.DobavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt";
            this.KontaktOsoba.Name = "KontaktOsoba";
            this.KontaktOsoba.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(111, 26);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(254, 20);
            this.nazivInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv dobavljača:";
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(381, 23);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 12;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 317);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dobavljaciGrid);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobavljači";
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dobavljaciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button traziButton;
    }
}