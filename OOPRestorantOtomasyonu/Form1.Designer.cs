
namespace OOPRestorantOtomasyonu
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
            this.cmbAnaYemek = new System.Windows.Forms.ComboBox();
            this.cmbAraSicak = new System.Windows.Forms.ComboBox();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.cmbTatli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.txtMasaNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAnaYemek
            // 
            this.cmbAnaYemek.FormattingEnabled = true;
            this.cmbAnaYemek.Location = new System.Drawing.Point(6, 42);
            this.cmbAnaYemek.Name = "cmbAnaYemek";
            this.cmbAnaYemek.Size = new System.Drawing.Size(152, 28);
            this.cmbAnaYemek.TabIndex = 0;
            // 
            // cmbAraSicak
            // 
            this.cmbAraSicak.FormattingEnabled = true;
            this.cmbAraSicak.Location = new System.Drawing.Point(6, 96);
            this.cmbAraSicak.Name = "cmbAraSicak";
            this.cmbAraSicak.Size = new System.Drawing.Size(152, 28);
            this.cmbAraSicak.TabIndex = 0;
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Location = new System.Drawing.Point(6, 150);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(152, 28);
            this.cmbIcecek.TabIndex = 0;
            // 
            // cmbTatli
            // 
            this.cmbTatli.FormattingEnabled = true;
            this.cmbTatli.Location = new System.Drawing.Point(7, 205);
            this.cmbTatli.Name = "cmbTatli";
            this.cmbTatli.Size = new System.Drawing.Size(152, 28);
            this.cmbTatli.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ana Yemek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara Sıcak";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "İçecek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tatlı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Masa Numarası";
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 20;
            this.lstSiparis.Location = new System.Drawing.Point(400, 36);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(666, 324);
            this.lstSiparis.TabIndex = 5;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(47, 361);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(99, 26);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(400, 395);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 46);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(957, 395);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(109, 46);
            this.btnCiro.TabIndex = 7;
            this.btnCiro.Text = "Ciro";
            this.btnCiro.UseVisualStyleBackColor = true;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // txtMasaNum
            // 
            this.txtMasaNum.Location = new System.Drawing.Point(168, 64);
            this.txtMasaNum.Name = "txtMasaNum";
            this.txtMasaNum.Size = new System.Drawing.Size(138, 26);
            this.txtMasaNum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Siparis Adedi";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.cmbAnaYemek);
            this.grpMenu.Controls.Add(this.cmbAraSicak);
            this.grpMenu.Controls.Add(this.cmbIcecek);
            this.grpMenu.Controls.Add(this.cmbTatli);
            this.grpMenu.Location = new System.Drawing.Point(12, 96);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(171, 239);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1078, 477);
            this.Controls.Add(this.txtMasaNum);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnaYemek;
        private System.Windows.Forms.ComboBox cmbAraSicak;
        private System.Windows.Forms.ComboBox cmbIcecek;
        private System.Windows.Forms.ComboBox cmbTatli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.TextBox txtMasaNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpMenu;
    }
}

