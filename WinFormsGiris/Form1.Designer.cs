namespace WinFormsGiris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numKapiSayisi = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlArabaTuru = new System.Windows.Forms.ComboBox();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbBeygirGucu = new System.Windows.Forms.TextBox();
            this.tbSifirYuz = new System.Windows.Forms.TextBox();
            this.cbIkinciEl = new System.Windows.Forms.CheckBox();
            this.bOlustur = new System.Windows.Forms.Button();
            this.bGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKapiSayisi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka :";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(120, 67);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(277, 21);
            this.tbMarka.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(120, 106);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(277, 21);
            this.tbModel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kapı Sayısı :";
            // 
            // numKapiSayisi
            // 
            this.numKapiSayisi.Location = new System.Drawing.Point(120, 136);
            this.numKapiSayisi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numKapiSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKapiSayisi.Name = "numKapiSayisi";
            this.numKapiSayisi.Size = new System.Drawing.Size(120, 21);
            this.numKapiSayisi.TabIndex = 5;
            this.numKapiSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKapiSayisi.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 344);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Araba Türü :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Beygir Gücü :";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Üretim :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "0 -100 :";
            // 
            // ddlArabaTuru
            // 
            this.ddlArabaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlArabaTuru.FormattingEnabled = true;
            this.ddlArabaTuru.Items.AddRange(new object[] {
            "Sedan",
            "Spor",
            "Hatchback",
            "Station Wagon"});
            this.ddlArabaTuru.Location = new System.Drawing.Point(120, 198);
            this.ddlArabaTuru.Name = "ddlArabaTuru";
            this.ddlArabaTuru.Size = new System.Drawing.Size(174, 22);
            this.ddlArabaTuru.TabIndex = 7;
            this.ddlArabaTuru.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(120, 257);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(200, 21);
            this.dtpUretimTarihi.TabIndex = 8;
            // 
            // tbBeygirGucu
            // 
            this.tbBeygirGucu.Location = new System.Drawing.Point(120, 170);
            this.tbBeygirGucu.Name = "tbBeygirGucu";
            this.tbBeygirGucu.Size = new System.Drawing.Size(277, 21);
            this.tbBeygirGucu.TabIndex = 4;
            this.tbBeygirGucu.TextChanged += new System.EventHandler(this.tbBeygirGucu_TextChanged);
            // 
            // tbSifirYuz
            // 
            this.tbSifirYuz.Location = new System.Drawing.Point(120, 230);
            this.tbSifirYuz.Name = "tbSifirYuz";
            this.tbSifirYuz.Size = new System.Drawing.Size(277, 21);
            this.tbSifirYuz.TabIndex = 4;
            this.tbSifirYuz.TextChanged += new System.EventHandler(this.tbBeygirGucu_TextChanged);
            // 
            // cbIkinciEl
            // 
            this.cbIkinciEl.AutoSize = true;
            this.cbIkinciEl.Location = new System.Drawing.Point(120, 293);
            this.cbIkinciEl.Name = "cbIkinciEl";
            this.cbIkinciEl.Size = new System.Drawing.Size(70, 18);
            this.cbIkinciEl.TabIndex = 9;
            this.cbIkinciEl.Text = "Ikinci el";
            this.cbIkinciEl.UseVisualStyleBackColor = true;
            this.cbIkinciEl.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bOlustur
            // 
            this.bOlustur.Location = new System.Drawing.Point(704, 335);
            this.bOlustur.Name = "bOlustur";
            this.bOlustur.Size = new System.Drawing.Size(131, 33);
            this.bOlustur.TabIndex = 10;
            this.bOlustur.Text = "Olustur";
            this.bOlustur.UseVisualStyleBackColor = true;
            this.bOlustur.Click += new System.EventHandler(this.bOlustur_Click);
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(567, 335);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(131, 33);
            this.bGetir.TabIndex = 10;
            this.bGetir.Text = "Getir";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(878, 380);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bOlustur);
            this.Controls.Add(this.cbIkinciEl);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.ddlArabaTuru);
            this.Controls.Add(this.numKapiSayisi);
            this.Controls.Add(this.tbSifirYuz);
            this.Controls.Add(this.tbBeygirGucu);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKapiSayisi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbMarka;
        private TextBox tbModel;
        private Label label3;
        private Label label4;
        private NumericUpDown numKapiSayisi;
        private Panel panel1;
        private Label label5;
        private ComboBox ddlArabaTuru;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpUretimTarihi;
        private TextBox tbBeygirGucu;
        private TextBox tbSifirYuz;
        private Label label8;
        private CheckBox cbIkinciEl;
        private Button bOlustur;
        private Button bGetir;
    }
}