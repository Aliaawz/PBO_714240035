namespace P9_714240035
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
            this.dataMhs = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.dataMhs2 = new System.Windows.Forms.GroupBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.textboxNohp = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.textboxAlamat = new System.Windows.Forms.TextBox();
            this.textboxNama = new System.Windows.Forms.TextBox();
            this.textboxNpm = new System.Windows.Forms.TextBox();
            this.labelHp = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelAng = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNpm = new System.Windows.Forms.Label();
            this.dataTombol = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataMhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.dataMhs2.SuspendLayout();
            this.dataTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMhs
            // 
            this.dataMhs.Controls.Add(this.DataMahasiswa);
            this.dataMhs.Location = new System.Drawing.Point(22, 12);
            this.dataMhs.Name = "dataMhs";
            this.dataMhs.Size = new System.Drawing.Size(937, 330);
            this.dataMhs.TabIndex = 0;
            this.dataMhs.TabStop = false;
            this.dataMhs.Text = "Table Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(6, 21);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 51;
            this.DataMahasiswa.RowTemplate.Height = 24;
            this.DataMahasiswa.Size = new System.Drawing.Size(925, 292);
            this.DataMahasiswa.TabIndex = 0;
            // 
            // dataMhs2
            // 
            this.dataMhs2.Controls.Add(this.comboBoxAngkatan);
            this.dataMhs2.Controls.Add(this.textboxNohp);
            this.dataMhs2.Controls.Add(this.textboxEmail);
            this.dataMhs2.Controls.Add(this.textboxAlamat);
            this.dataMhs2.Controls.Add(this.textboxNama);
            this.dataMhs2.Controls.Add(this.textboxNpm);
            this.dataMhs2.Controls.Add(this.labelHp);
            this.dataMhs2.Controls.Add(this.Email);
            this.dataMhs2.Controls.Add(this.labelAlamat);
            this.dataMhs2.Controls.Add(this.labelAng);
            this.dataMhs2.Controls.Add(this.labelNama);
            this.dataMhs2.Controls.Add(this.labelNpm);
            this.dataMhs2.Location = new System.Drawing.Point(22, 348);
            this.dataMhs2.Name = "dataMhs2";
            this.dataMhs2.Size = new System.Drawing.Size(505, 320);
            this.dataMhs2.TabIndex = 1;
            this.dataMhs2.TabStop = false;
            this.dataMhs2.Text = "Table Data Mahasiswa";
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Location = new System.Drawing.Point(128, 113);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(358, 24);
            this.comboBoxAngkatan.TabIndex = 0;
            // 
            // textboxNohp
            // 
            this.textboxNohp.Location = new System.Drawing.Point(128, 266);
            this.textboxNohp.Name = "textboxNohp";
            this.textboxNohp.Size = new System.Drawing.Size(358, 22);
            this.textboxNohp.TabIndex = 10;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(128, 219);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(358, 22);
            this.textboxEmail.TabIndex = 9;
            // 
            // textboxAlamat
            // 
            this.textboxAlamat.Location = new System.Drawing.Point(128, 154);
            this.textboxAlamat.Name = "textboxAlamat";
            this.textboxAlamat.Size = new System.Drawing.Size(358, 22);
            this.textboxAlamat.TabIndex = 8;
            // 
            // textboxNama
            // 
            this.textboxNama.Location = new System.Drawing.Point(128, 73);
            this.textboxNama.Name = "textboxNama";
            this.textboxNama.Size = new System.Drawing.Size(358, 22);
            this.textboxNama.TabIndex = 7;
            // 
            // textboxNpm
            // 
            this.textboxNpm.Location = new System.Drawing.Point(128, 32);
            this.textboxNpm.Name = "textboxNpm";
            this.textboxNpm.Size = new System.Drawing.Size(358, 22);
            this.textboxNpm.TabIndex = 6;
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Location = new System.Drawing.Point(15, 269);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(47, 16);
            this.labelHp.TabIndex = 5;
            this.labelHp.Text = "No HP";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(15, 225);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(15, 160);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(49, 16);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelAng
            // 
            this.labelAng.AutoSize = true;
            this.labelAng.Location = new System.Drawing.Point(15, 116);
            this.labelAng.Name = "labelAng";
            this.labelAng.Size = new System.Drawing.Size(64, 16);
            this.labelAng.TabIndex = 2;
            this.labelAng.Text = "Angkatan";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(15, 73);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(44, 16);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // labelNpm
            // 
            this.labelNpm.AutoSize = true;
            this.labelNpm.Location = new System.Drawing.Point(16, 35);
            this.labelNpm.Name = "labelNpm";
            this.labelNpm.Size = new System.Drawing.Size(37, 16);
            this.labelNpm.TabIndex = 0;
            this.labelNpm.Text = "NPM";
            // 
            // dataTombol
            // 
            this.dataTombol.Controls.Add(this.btnHapus);
            this.dataTombol.Controls.Add(this.btnUbah);
            this.dataTombol.Controls.Add(this.btnSimpan);
            this.dataTombol.Controls.Add(this.btnRefresh);
            this.dataTombol.Location = new System.Drawing.Point(533, 421);
            this.dataTombol.Name = "dataTombol";
            this.dataTombol.Size = new System.Drawing.Size(426, 212);
            this.dataTombol.TabIndex = 2;
            this.dataTombol.TabStop = false;
            this.dataTombol.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(6, 159);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(414, 38);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(6, 116);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(414, 37);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 70);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(414, 40);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(414, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 680);
            this.Controls.Add(this.dataTombol);
            this.Controls.Add(this.dataMhs2);
            this.Controls.Add(this.dataMhs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.dataMhs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.dataMhs2.ResumeLayout(false);
            this.dataMhs2.PerformLayout();
            this.dataTombol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataMhs;
        private System.Windows.Forms.GroupBox dataMhs2;
        private System.Windows.Forms.GroupBox dataTombol;
        private System.Windows.Forms.TextBox textboxAlamat;
        private System.Windows.Forms.TextBox textboxNama;
        private System.Windows.Forms.TextBox textboxNpm;
        private System.Windows.Forms.Label labelHp;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelAng;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNpm;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.TextBox textboxNohp;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
    }
}