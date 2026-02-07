using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714240035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, "");
            epWrong.SetError(textBox, "");
            epCorrect.SetError(textBox, "");

            if (!string.IsNullOrEmpty(warningMessage))
            {
                epWarning.SetError(textBox, warningMessage);
            }

            if (!string.IsNullOrEmpty(wrongMessage))
            {
                epWrong.SetError(textBox, wrongMessage);
            }

            if (!string.IsNullOrEmpty(correctMessage))
            {
                epCorrect.SetError(textBox, correctMessage);
            }
        }


        private void NamaPengirim_TextChanged(object sender, EventArgs e)
        {
            if (NamaPengirim.Text == "")
            {
                SetErrorMessages(NamaPengirim, "Nama tidak boleh kosong!", "", "");
            }
            else if (NamaPengirim.Text.All(Char.IsLetter))
            {
                SetErrorMessages(NamaPengirim, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(NamaPengirim, "", "Nama hanya boleh huruf!", "");
            }
        }

        private void NamaPenerima_Leave(object sender, EventArgs e)
        {
            if (NamaPenerima.Text == "")
            {
                SetErrorMessages(NamaPenerima, "Nama penerima wajib diisi!", "", "");
            }
            else
            {
                SetErrorMessages(NamaPenerima, "", "", "Betul!");
            }
        }

        private void Nohp_TextChanged(object sender, EventArgs e)
        {
            if (Nohp.Text == "")
            {
                SetErrorMessages(Nohp, "Nomor HP tidak boleh kosong!", "", "");
            }
            else if (Nohp.Text.All(Char.IsDigit))
            {
                SetErrorMessages(Nohp, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(Nohp, "", "Nomor HP hanya boleh angka!", "");
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                SetErrorMessages(Email, "Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                SetErrorMessages(Email, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(Email, "", "Format email salah!", "");
            }
        }

        private void Berat_TextChanged(object sender, EventArgs e)
        {
            if (Berat.Text == "")
            {
                SetErrorMessages(Berat, "Berat tidak boleh kosong!", "", "");
                return;
            }

            if (!Berat.Text.All(Char.IsDigit))
            {
                SetErrorMessages(Berat, "", "Berat harus angka!", "");
                return;
            }

            int berat = Convert.ToInt32(Berat.Text);

            if (berat > 0)
            {
                SetErrorMessages(Berat, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(Berat, "", "Berat harus lebih dari 0!", "");
            }
        }

        private void Kode_TextChanged(object sender, EventArgs e)
        {
            if (Kode.Text == "")
            {
                SetErrorMessages(Kode, "Kode tidak boleh kosong!", "", "");
            }
            else if (Kode.Text.Length == 5)
            {
                SetErrorMessages(Kode, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(Kode, "", "Kode gudang harus 5 karakter!", "");
            }
        }

        private void Asal_TextChanged(object sender, EventArgs e)
        {
            int pos = Asal.SelectionStart;
            Asal.Text = Asal.Text.ToUpper();
            Asal.SelectionStart = pos;
        }

        private void Tujuan_TextChanged(object sender, EventArgs e)
        {
            int pos = Tujuan.SelectionStart;
            Tujuan.Text = Tujuan.Text.ToLower();
            Tujuan.SelectionStart = pos;
        }
        private bool ValidasiSemua()
        {
            foreach (Control c in this.Controls)
            {
                if (epWarning.GetError(c).Length > 0 ||
                    epWrong.GetError(c).Length > 0)
                {
                    return false;
                }
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidasiSemua())
            {
                MessageBox.Show("Masih ada data yang tidak valid. Periksa kembali!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(
                "Nama Pengirim: " + NamaPengirim.Text + "\n" +
                "Nama Penerima: " + NamaPenerima.Text + "\n" +
                "No HP: " + Nohp.Text + "\n" +
                "Email: " + Email.Text + "\n" +
                "Berat Barang: " + Berat.Text + "\n" +
                "Kode Gudang: " + Kode.Text + "\n" +
                "Kota Asal: " + Asal.Text + "\n" +
                "Kota Tujuan: " + Tujuan.Text
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }



