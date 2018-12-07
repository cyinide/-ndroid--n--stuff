namespace eProdaja_UI.Products
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
            this.cijenaInput = new System.Windows.Forms.MaskedTextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jediniceMjereList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vrsteProizvodaList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(67, 91);
            this.cijenaInput.Mask = "0000.00";
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(65, 20);
            this.cijenaInput.TabIndex = 37;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(512, 179);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 43);
            this.dodajButton.TabIndex = 40;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AllowUserToAddRows = false;
            this.proizvodiGrid.AllowUserToDeleteRows = false;
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodiGrid.Location = new System.Drawing.Point(0, 240);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.ReadOnly = true;
            this.proizvodiGrid.RowTemplate.Height = 100;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(633, 212);
            this.proizvodiGrid.TabIndex = 41;
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.Location = new System.Drawing.Point(282, 135);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(51, 23);
            this.dodajSlikuButton.TabIndex = 38;
            this.dodajSlikuButton.Text = "Dodaj";
            this.dodajSlikuButton.UseVisualStyleBackColor = true;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(490, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 49;
            this.pictureBox.TabStop = false;
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(67, 137);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(209, 20);
            this.slikaInput.TabIndex = 43;
            this.slikaInput.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Slika:";
            // 
            // jediniceMjereList
            // 
            this.jediniceMjereList.FormattingEnabled = true;
            this.jediniceMjereList.Location = new System.Drawing.Point(211, 90);
            this.jediniceMjereList.Name = "jediniceMjereList";
            this.jediniceMjereList.Size = new System.Drawing.Size(65, 21);
            this.jediniceMjereList.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Jed. mjere:";
            // 
            // vrsteProizvodaList
            // 
            this.vrsteProizvodaList.FormattingEnabled = true;
            this.vrsteProizvodaList.Location = new System.Drawing.Point(67, 12);
            this.vrsteProizvodaList.Name = "vrsteProizvodaList";
            this.vrsteProizvodaList.Size = new System.Drawing.Size(209, 21);
            this.vrsteProizvodaList.TabIndex = 34;
            this.vrsteProizvodaList.SelectedIndexChanged += new System.EventHandler(this.vrsteProizvodaList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cijena:";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(67, 65);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(209, 20);
            this.nazivInput.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Naziv:";
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(67, 39);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(209, 20);
            this.sifraInput.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Šifra:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 452);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.dodajSlikuButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jediniceMjereList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vrsteProizvodaList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi proizvod";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cijenaInput;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.DataGridView proizvodiGrid;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox jediniceMjereList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vrsteProizvodaList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}