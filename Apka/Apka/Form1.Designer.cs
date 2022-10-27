
namespace Apka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelForm = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelKOD = new System.Windows.Forms.Label();
            this.labelZDJ = new System.Windows.Forms.Label();
            this.labelNR = new System.Windows.Forms.Label();
            this.maskedTextBoxNR = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxKOD = new System.Windows.Forms.MaskedTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Wyswietl = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Label();
            this.zdjecie = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForm
            // 
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelForm.Location = new System.Drawing.Point(113, 26);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(206, 46);
            this.labelForm.TabIndex = 0;
            this.labelForm.Text = "Formularz";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(35, 94);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(35, 135);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 2;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(35, 75);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(56, 13);
            this.labelNazwisko.TabIndex = 3;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(35, 119);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 4;
            this.labelImie.Text = "Imię:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(35, 158);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(82, 13);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "Data urodzenia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(35, 217);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdres.TabIndex = 7;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(35, 201);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(34, 13);
            this.labelAdres.TabIndex = 8;
            this.labelAdres.Text = "Adres";
            // 
            // labelKOD
            // 
            this.labelKOD.AutoSize = true;
            this.labelKOD.Location = new System.Drawing.Point(38, 244);
            this.labelKOD.Name = "labelKOD";
            this.labelKOD.Size = new System.Drawing.Size(29, 13);
            this.labelKOD.TabIndex = 9;
            this.labelKOD.Text = "Kod:";
            // 
            // labelZDJ
            // 
            this.labelZDJ.AutoSize = true;
            this.labelZDJ.Location = new System.Drawing.Point(38, 288);
            this.labelZDJ.Name = "labelZDJ";
            this.labelZDJ.Size = new System.Drawing.Size(45, 13);
            this.labelZDJ.TabIndex = 12;
            this.labelZDJ.Text = "Zdjęcie:";
            // 
            // labelNR
            // 
            this.labelNR.AutoSize = true;
            this.labelNR.Location = new System.Drawing.Point(38, 327);
            this.labelNR.Name = "labelNR";
            this.labelNR.Size = new System.Drawing.Size(82, 13);
            this.labelNR.TabIndex = 13;
            this.labelNR.Text = "Numer telefonu:";
            this.labelNR.Click += new System.EventHandler(this.label8_Click);
            // 
            // maskedTextBoxNR
            // 
            this.maskedTextBoxNR.Location = new System.Drawing.Point(35, 343);
            this.maskedTextBoxNR.Mask = "999-999-999";
            this.maskedTextBoxNR.Name = "maskedTextBoxNR";
            this.maskedTextBoxNR.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNR.TabIndex = 14;
            // 
            // maskedTextBoxKOD
            // 
            this.maskedTextBoxKOD.Location = new System.Drawing.Point(35, 261);
            this.maskedTextBoxKOD.Mask = "00-999";
            this.maskedTextBoxKOD.Name = "maskedTextBoxKOD";
            this.maskedTextBoxKOD.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxKOD.TabIndex = 15;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(35, 369);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 16;
            this.Send.Text = "Wyślij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Wyswietl
            // 
            this.Wyswietl.AutoSize = true;
            this.Wyswietl.Location = new System.Drawing.Point(312, 58);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(0, 13);
            this.Wyswietl.TabIndex = 17;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Location = new System.Drawing.Point(315, 94);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(69, 13);
            this.show.TabIndex = 18;
            this.show.Text = "Wyswietlanie";
            // 
            // zdjecie
            // 
            this.zdjecie.Location = new System.Drawing.Point(35, 304);
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Size = new System.Drawing.Size(100, 20);
            this.zdjecie.TabIndex = 19;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(315, 343);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 50);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 20;
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 538);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.zdjecie);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Wyswietl);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.maskedTextBoxKOD);
            this.Controls.Add(this.maskedTextBoxNR);
            this.Controls.Add(this.labelNR);
            this.Controls.Add(this.labelZDJ);
            this.Controls.Add(this.labelKOD);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.labelForm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelKOD;
        private System.Windows.Forms.Label labelZDJ;
        private System.Windows.Forms.Label labelNR;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNR;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKOD;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label Wyswietl;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.TextBox zdjecie;
        private System.Windows.Forms.PictureBox picture;
    }
}

