namespace P6_4_714240035
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
            this.NamaPengirim = new System.Windows.Forms.TextBox();
            this.Form = new System.Windows.Forms.Label();
            this.txt_pengirim = new System.Windows.Forms.Label();
            this.txt_penerima = new System.Windows.Forms.Label();
            this.txt_nohp = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_berat = new System.Windows.Forms.Label();
            this.txt_gudang = new System.Windows.Forms.Label();
            this.txt_asal = new System.Windows.Forms.Label();
            this.txt_tujuan = new System.Windows.Forms.Label();
            this.NamaPenerima = new System.Windows.Forms.TextBox();
            this.Nohp = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Berat = new System.Windows.Forms.TextBox();
            this.Kode = new System.Windows.Forms.TextBox();
            this.Asal = new System.Windows.Forms.TextBox();
            this.Tujuan = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // NamaPengirim
            // 
            this.NamaPengirim.Location = new System.Drawing.Point(401, 70);
            this.NamaPengirim.Name = "NamaPengirim";
            this.NamaPengirim.Size = new System.Drawing.Size(191, 22);
            this.NamaPengirim.TabIndex = 0;
            this.NamaPengirim.TextChanged += new System.EventHandler(this.NamaPengirim_TextChanged);
            // 
            // Form
            // 
            this.Form.AutoSize = true;
            this.Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Form.Location = new System.Drawing.Point(204, 23);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(298, 28);
            this.Form.TabIndex = 1;
            this.Form.Text = "FORM PENGANTARAN BARANG";
            // 
            // txt_pengirim
            // 
            this.txt_pengirim.AutoSize = true;
            this.txt_pengirim.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pengirim.Location = new System.Drawing.Point(92, 71);
            this.txt_pengirim.Name = "txt_pengirim";
            this.txt_pengirim.Size = new System.Drawing.Size(129, 23);
            this.txt_pengirim.TabIndex = 2;
            this.txt_pengirim.Text = "Nama Pengirim";
            // 
            // txt_penerima
            // 
            this.txt_penerima.AutoSize = true;
            this.txt_penerima.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penerima.Location = new System.Drawing.Point(92, 108);
            this.txt_penerima.Name = "txt_penerima";
            this.txt_penerima.Size = new System.Drawing.Size(134, 23);
            this.txt_penerima.TabIndex = 3;
            this.txt_penerima.Text = "Nama Penerima";
            // 
            // txt_nohp
            // 
            this.txt_nohp.AutoSize = true;
            this.txt_nohp.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nohp.Location = new System.Drawing.Point(92, 144);
            this.txt_nohp.Name = "txt_nohp";
            this.txt_nohp.Size = new System.Drawing.Size(58, 23);
            this.txt_nohp.TabIndex = 4;
            this.txt_nohp.Text = "No HP";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(92, 180);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(134, 23);
            this.txt_email.TabIndex = 5;
            this.txt_email.Text = "Email Penerima";
            // 
            // txt_berat
            // 
            this.txt_berat.AutoSize = true;
            this.txt_berat.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_berat.Location = new System.Drawing.Point(92, 219);
            this.txt_berat.Name = "txt_berat";
            this.txt_berat.Size = new System.Drawing.Size(110, 23);
            this.txt_berat.TabIndex = 6;
            this.txt_berat.Text = "Berat Barang";
            // 
            // txt_gudang
            // 
            this.txt_gudang.AutoSize = true;
            this.txt_gudang.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gudang.Location = new System.Drawing.Point(92, 255);
            this.txt_gudang.Name = "txt_gudang";
            this.txt_gudang.Size = new System.Drawing.Size(176, 23);
            this.txt_gudang.TabIndex = 7;
            this.txt_gudang.Text = "Kode Gudang (Min 5)";
            // 
            // txt_asal
            // 
            this.txt_asal.AutoSize = true;
            this.txt_asal.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asal.Location = new System.Drawing.Point(92, 291);
            this.txt_asal.Name = "txt_asal";
            this.txt_asal.Size = new System.Drawing.Size(83, 23);
            this.txt_asal.TabIndex = 8;
            this.txt_asal.Text = "Kota Asal";
            // 
            // txt_tujuan
            // 
            this.txt_tujuan.AutoSize = true;
            this.txt_tujuan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tujuan.Location = new System.Drawing.Point(92, 327);
            this.txt_tujuan.Name = "txt_tujuan";
            this.txt_tujuan.Size = new System.Drawing.Size(105, 23);
            this.txt_tujuan.TabIndex = 9;
            this.txt_tujuan.Text = "Kota Tujuan";
            // 
            // NamaPenerima
            // 
            this.NamaPenerima.Location = new System.Drawing.Point(401, 108);
            this.NamaPenerima.Name = "NamaPenerima";
            this.NamaPenerima.Size = new System.Drawing.Size(191, 22);
            this.NamaPenerima.TabIndex = 10;
            this.NamaPenerima.Leave += new System.EventHandler(this.NamaPenerima_Leave);
            // 
            // Nohp
            // 
            this.Nohp.Location = new System.Drawing.Point(401, 144);
            this.Nohp.Name = "Nohp";
            this.Nohp.Size = new System.Drawing.Size(191, 22);
            this.Nohp.TabIndex = 11;
            this.Nohp.TextChanged += new System.EventHandler(this.Nohp_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(401, 180);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(191, 22);
            this.Email.TabIndex = 12;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Berat
            // 
            this.Berat.Location = new System.Drawing.Point(401, 219);
            this.Berat.Name = "Berat";
            this.Berat.Size = new System.Drawing.Size(78, 22);
            this.Berat.TabIndex = 13;
            this.Berat.TextChanged += new System.EventHandler(this.Berat_TextChanged);
            // 
            // Kode
            // 
            this.Kode.Location = new System.Drawing.Point(401, 255);
            this.Kode.Name = "Kode";
            this.Kode.Size = new System.Drawing.Size(191, 22);
            this.Kode.TabIndex = 14;
            this.Kode.TextChanged += new System.EventHandler(this.Kode_TextChanged);
            // 
            // Asal
            // 
            this.Asal.Location = new System.Drawing.Point(401, 291);
            this.Asal.Name = "Asal";
            this.Asal.Size = new System.Drawing.Size(191, 22);
            this.Asal.TabIndex = 15;
            this.Asal.TextChanged += new System.EventHandler(this.Asal_TextChanged);
            // 
            // Tujuan
            // 
            this.Tujuan.Location = new System.Drawing.Point(401, 327);
            this.Tujuan.Name = "Tujuan";
            this.Tujuan.Size = new System.Drawing.Size(191, 22);
            this.Tujuan.TabIndex = 16;
            this.Tujuan.TextChanged += new System.EventHandler(this.Tujuan_TextChanged);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(401, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kg";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(164, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(707, 420);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tujuan);
            this.Controls.Add(this.Asal);
            this.Controls.Add(this.Kode);
            this.Controls.Add(this.Berat);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nohp);
            this.Controls.Add(this.NamaPenerima);
            this.Controls.Add(this.txt_tujuan);
            this.Controls.Add(this.txt_asal);
            this.Controls.Add(this.txt_gudang);
            this.Controls.Add(this.txt_berat);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nohp);
            this.Controls.Add(this.txt_penerima);
            this.Controls.Add(this.txt_pengirim);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.NamaPengirim);
            this.Name = "Form1";
            this.Text = "Pemesanan Barang";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NamaPengirim;
        private System.Windows.Forms.Label txt_pengirim;
        private System.Windows.Forms.Label txt_penerima;
        private System.Windows.Forms.Label txt_nohp;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_berat;
        private System.Windows.Forms.Label txt_gudang;
        private System.Windows.Forms.Label txt_asal;
        private System.Windows.Forms.Label txt_tujuan;
        private System.Windows.Forms.TextBox NamaPenerima;
        private System.Windows.Forms.TextBox Nohp;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Berat;
        private System.Windows.Forms.TextBox Kode;
        private System.Windows.Forms.TextBox Asal;
        private System.Windows.Forms.TextBox Tujuan;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Form;
        private System.Windows.Forms.Button button2;
    }
}