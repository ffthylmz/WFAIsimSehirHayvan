namespace WFAPractice2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHarf = new System.Windows.Forms.Button();
            this.btnZaman = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtHayvan = new System.Windows.Forms.TextBox();
            this.txtUnlu = new System.Windows.Forms.TextBox();
            this.txtEsya = new System.Windows.Forms.TextBox();
            this.txtBitki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblHarf = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnHarf
            // 
            this.btnHarf.Location = new System.Drawing.Point(167, 26);
            this.btnHarf.Name = "btnHarf";
            this.btnHarf.Size = new System.Drawing.Size(94, 34);
            this.btnHarf.TabIndex = 0;
            this.btnHarf.Text = "Harf Ver";
            this.btnHarf.UseVisualStyleBackColor = true;
            this.btnHarf.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // btnZaman
            // 
            this.btnZaman.Location = new System.Drawing.Point(394, 26);
            this.btnZaman.Name = "btnZaman";
            this.btnZaman.Size = new System.Drawing.Size(94, 34);
            this.btnZaman.TabIndex = 1;
            this.btnZaman.Text = "Başla";
            this.btnZaman.UseVisualStyleBackColor = true;
            this.btnZaman.Click += new System.EventHandler(this.btnZaman_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(694, 148);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(94, 34);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 156);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(105, 20);
            this.txtIsim.TabIndex = 3;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(123, 156);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(105, 20);
            this.txtSehir.TabIndex = 4;
            // 
            // txtHayvan
            // 
            this.txtHayvan.Location = new System.Drawing.Point(234, 156);
            this.txtHayvan.Name = "txtHayvan";
            this.txtHayvan.Size = new System.Drawing.Size(105, 20);
            this.txtHayvan.TabIndex = 5;
            // 
            // txtUnlu
            // 
            this.txtUnlu.Location = new System.Drawing.Point(567, 156);
            this.txtUnlu.Name = "txtUnlu";
            this.txtUnlu.Size = new System.Drawing.Size(105, 20);
            this.txtUnlu.TabIndex = 8;
            // 
            // txtEsya
            // 
            this.txtEsya.Location = new System.Drawing.Point(456, 156);
            this.txtEsya.Name = "txtEsya";
            this.txtEsya.Size = new System.Drawing.Size(105, 20);
            this.txtEsya.TabIndex = 7;
            // 
            // txtBitki
            // 
            this.txtBitki.Location = new System.Drawing.Point(345, 156);
            this.txtBitki.Name = "txtBitki";
            this.txtBitki.Size = new System.Drawing.Size(105, 20);
            this.txtBitki.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İsim(10)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şehir(10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hayvan(10)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bitki(10)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Eşya(10)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ünlü(10)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min. 2 Harf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Min. 3 Harf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Min. 2 Harf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Min. 3 Harf";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Min. 3 Harf";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(567, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Min. 5 Harf";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(15, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(435, 26);
            this.label13.TabIndex = 21;
            this.label13.Text = "Oyun Şekli: 60 Saniye içinde size yukarda verilen harfe göre, aşağıdaki alanları," +
    " ilk harfi\r\nverilen harf olacak şekilde doldurun. Örnek: Harf: A; Ayşe-Adana-At-" +
    "Ayva-Ayna-Aleyna Tilki\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(12, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(350, 104);
            this.label14.TabIndex = 22;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(515, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "SÜRE:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(561, 37);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 13);
            this.lblSure.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(276, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "HARF:";
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Location = new System.Drawing.Point(323, 37);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(0, 13);
            this.lblHarf.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 377);
            this.Controls.Add(this.lblHarf);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnlu);
            this.Controls.Add(this.txtEsya);
            this.Controls.Add(this.txtBitki);
            this.Controls.Add(this.txtHayvan);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnZaman);
            this.Controls.Add(this.btnHarf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHarf;
        private System.Windows.Forms.Button btnZaman;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtHayvan;
        private System.Windows.Forms.TextBox txtUnlu;
        private System.Windows.Forms.TextBox txtEsya;
        private System.Windows.Forms.TextBox txtBitki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.Timer timer1;
    }
}

