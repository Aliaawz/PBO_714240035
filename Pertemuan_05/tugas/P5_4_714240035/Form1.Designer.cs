namespace P5_4_714240035
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.jenis = new System.Windows.Forms.Label();
            this.lahir = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kelas = new System.Windows.Forms.GroupBox();
            this.panahan = new System.Windows.Forms.CheckBox();
            this.voli = new System.Windows.Forms.CheckBox();
            this.Tangkis = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.renang = new System.Windows.Forms.CheckBox();
            this.bola = new System.Windows.Forms.CheckBox();
            this.jadwal = new System.Windows.Forms.GroupBox();
            this.minggu = new System.Windows.Forms.RadioButton();
            this.sabtu = new System.Windows.Forms.RadioButton();
            this.selasa = new System.Windows.Forms.RadioButton();
            this.senin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kelas.SuspendLayout();
            this.jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(269, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.BackColor = System.Drawing.Color.Transparent;
            this.nama.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.Color.AliceBlue;
            this.nama.Location = new System.Drawing.Point(159, 71);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(48, 20);
            this.nama.TabIndex = 1;
            this.nama.Text = "Nama";
            // 
            // jenis
            // 
            this.jenis.AutoSize = true;
            this.jenis.BackColor = System.Drawing.Color.Transparent;
            this.jenis.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jenis.Location = new System.Drawing.Point(159, 109);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(106, 20);
            this.jenis.TabIndex = 2;
            this.jenis.Text = "Jenis Kelamin";
            // 
            // lahir
            // 
            this.lahir.AutoSize = true;
            this.lahir.BackColor = System.Drawing.Color.Transparent;
            this.lahir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lahir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lahir.Location = new System.Drawing.Point(164, 149);
            this.lahir.Name = "lahir";
            this.lahir.Size = new System.Drawing.Size(101, 20);
            this.lahir.TabIndex = 3;
            this.lahir.Text = "Tanggal Lahir";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(441, 69);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(190, 22);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Pilih Jenis Kelamin--",
            "Laki-laki",
            "Perempuan"});
            this.comboBox1.Location = new System.Drawing.Point(441, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // kelas
            // 
            this.kelas.BackColor = System.Drawing.Color.Transparent;
            this.kelas.Controls.Add(this.panahan);
            this.kelas.Controls.Add(this.voli);
            this.kelas.Controls.Add(this.Tangkis);
            this.kelas.Controls.Add(this.Basket);
            this.kelas.Controls.Add(this.Yoga);
            this.kelas.Controls.Add(this.Tenis);
            this.kelas.Controls.Add(this.renang);
            this.kelas.Controls.Add(this.bola);
            this.kelas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kelas.Location = new System.Drawing.Point(50, 201);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(316, 200);
            this.kelas.TabIndex = 6;
            this.kelas.TabStop = false;
            this.kelas.Text = "Pilihan Kelas";
            // 
            // panahan
            // 
            this.panahan.AutoSize = true;
            this.panahan.Location = new System.Drawing.Point(192, 157);
            this.panahan.Name = "panahan";
            this.panahan.Size = new System.Drawing.Size(83, 20);
            this.panahan.TabIndex = 7;
            this.panahan.Text = "Panahan";
            this.panahan.UseVisualStyleBackColor = true;
            // 
            // voli
            // 
            this.voli.AutoSize = true;
            this.voli.Location = new System.Drawing.Point(192, 115);
            this.voli.Name = "voli";
            this.voli.Size = new System.Drawing.Size(52, 20);
            this.voli.TabIndex = 6;
            this.voli.Text = "Voli";
            this.voli.UseVisualStyleBackColor = true;
            // 
            // Tangkis
            // 
            this.Tangkis.AutoSize = true;
            this.Tangkis.Location = new System.Drawing.Point(192, 71);
            this.Tangkis.Name = "Tangkis";
            this.Tangkis.Size = new System.Drawing.Size(107, 20);
            this.Tangkis.TabIndex = 5;
            this.Tangkis.Text = "Bulu Tangkis";
            this.Tangkis.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(192, 30);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(71, 20);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(16, 157);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(62, 20);
            this.Yoga.TabIndex = 3;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(16, 115);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(63, 20);
            this.Tenis.TabIndex = 2;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            // 
            // renang
            // 
            this.renang.AutoSize = true;
            this.renang.Location = new System.Drawing.Point(16, 71);
            this.renang.Name = "renang";
            this.renang.Size = new System.Drawing.Size(77, 20);
            this.renang.TabIndex = 1;
            this.renang.Text = "Renang";
            this.renang.UseVisualStyleBackColor = true;
            // 
            // bola
            // 
            this.bola.AutoSize = true;
            this.bola.Location = new System.Drawing.Point(16, 30);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(100, 20);
            this.bola.TabIndex = 0;
            this.bola.Text = "Sepak Bola";
            this.bola.UseVisualStyleBackColor = true;
            // 
            // jadwal
            // 
            this.jadwal.BackColor = System.Drawing.Color.Transparent;
            this.jadwal.Controls.Add(this.minggu);
            this.jadwal.Controls.Add(this.sabtu);
            this.jadwal.Controls.Add(this.selasa);
            this.jadwal.Controls.Add(this.senin);
            this.jadwal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.jadwal.Location = new System.Drawing.Point(441, 201);
            this.jadwal.Name = "jadwal";
            this.jadwal.Size = new System.Drawing.Size(328, 200);
            this.jadwal.TabIndex = 7;
            this.jadwal.TabStop = false;
            this.jadwal.Text = "Pilihan Jadwal";
            // 
            // minggu
            // 
            this.minggu.AutoSize = true;
            this.minggu.Location = new System.Drawing.Point(25, 156);
            this.minggu.Name = "minggu";
            this.minggu.Size = new System.Drawing.Size(141, 20);
            this.minggu.TabIndex = 3;
            this.minggu.TabStop = true;
            this.minggu.Text = "Minggu,13:00-20:00";
            this.minggu.UseVisualStyleBackColor = true;
            // 
            // sabtu
            // 
            this.sabtu.AutoSize = true;
            this.sabtu.Location = new System.Drawing.Point(25, 114);
            this.sabtu.Name = "sabtu";
            this.sabtu.Size = new System.Drawing.Size(204, 20);
            this.sabtu.TabIndex = 2;
            this.sabtu.TabStop = true;
            this.sabtu.Text = "Sabtu s/d Minggu, 09:00-11:00";
            this.sabtu.UseVisualStyleBackColor = true;
            // 
            // selasa
            // 
            this.selasa.AutoSize = true;
            this.selasa.Location = new System.Drawing.Point(25, 71);
            this.selasa.Name = "selasa";
            this.selasa.Size = new System.Drawing.Size(205, 20);
            this.selasa.TabIndex = 1;
            this.selasa.TabStop = true;
            this.selasa.Text = "Selasa s/d Kamis, 14:00-16:00\r\n";
            this.selasa.UseVisualStyleBackColor = true;
            // 
            // senin
            // 
            this.senin.AutoSize = true;
            this.senin.Location = new System.Drawing.Point(25, 33);
            this.senin.Name = "senin";
            this.senin.Size = new System.Drawing.Size(192, 20);
            this.senin.TabIndex = 0;
            this.senin.TabStop = true;
            this.senin.Text = "Senin s/d Rabu, 14:00-16:00";
            this.senin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(242, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jadwal);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lahir);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.kelas.ResumeLayout(false);
            this.kelas.PerformLayout();
            this.jadwal.ResumeLayout(false);
            this.jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label jenis;
        private System.Windows.Forms.Label lahir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox kelas;
        private System.Windows.Forms.CheckBox bola;
        private System.Windows.Forms.GroupBox jadwal;
        private System.Windows.Forms.CheckBox panahan;
        private System.Windows.Forms.CheckBox voli;
        private System.Windows.Forms.CheckBox Tangkis;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox renang;
        private System.Windows.Forms.RadioButton senin;
        private System.Windows.Forms.RadioButton selasa;
        private System.Windows.Forms.RadioButton minggu;
        private System.Windows.Forms.RadioButton sabtu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}