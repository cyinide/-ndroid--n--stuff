namespace eProdaja_UI.Users
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Uloge:";
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(106, 110);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(195, 20);
            this.telefonInput.TabIndex = 36;
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(106, 179);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(195, 20);
            this.lozinkaInput.TabIndex = 39;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(106, 153);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(195, 20);
            this.korisnickoImeInput.TabIndex = 38;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Telefon:";
            // 
            // dodajButton
            // 
            this.dodajButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajButton.Location = new System.Drawing.Point(203, 281);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 30);
            this.dodajButton.TabIndex = 42;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ulogeList
            // 
            this.ulogeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulogeList.CheckOnClick = true;
            this.ulogeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(106, 205);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(195, 62);
            this.ulogeList.TabIndex = 40;
            this.ulogeList.Validating += new System.ComponentModel.CancelEventHandler(this.ulogeList_Validating);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(106, 81);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(195, 20);
            this.emailInput.TabIndex = 35;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "E-mail:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(106, 55);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(195, 20);
            this.prezimeInput.TabIndex = 33;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(106, 29);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(195, 20);
            this.imeInput.TabIndex = 32;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 334);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}