using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714240035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox ini tidak boleh kosong", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Betul");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka2.Text))
            {
                SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
            }
            else
            {

                if (txtAngka2.Text.All(Char.IsNumber))
                {
                    SetErrorMessages(txtAngka2, "", "", "Betul!");
                }
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text))
            {
                SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");

                SetErrorMessages(txtAngka2, "", "", "");
                return;
            }

            if (txtAngka1.Text.All(Char.IsNumber) && txtAngka2.Text.All(Char.IsNumber))
            {
                try
                {
                    int angka1 = Convert.ToInt32(txtAngka1.Text);
                    int angka2 = Convert.ToInt32(txtAngka2.Text);

                    SetErrorMessages(txtAngka1, "", "", "");

                    if (angka1 > angka2)
                    {

                        string successMsg = "Angka 1 lebih besar dari Angka 2";
                        SetErrorMessages(txtAngka1, "", "", successMsg);
                        SetErrorMessages(txtAngka2, "", "", successMsg);
                    }
                    else
                    {
                        string errorMsg = "Angka 1 harus lebih besar dari Angka 2";
                        SetErrorMessages(txtAngka1, "", errorMsg, "");
                        SetErrorMessages(txtAngka2, "", errorMsg, "");
                    }
                }
                catch (FormatException)
                {
                    SetErrorMessages(txtAngka1, "", "Input harus berupa angka!", "");
                    SetErrorMessages(txtAngka2, "", "Input harus berupa angka!", "");
                }
            }
            else
            {
                if (txtAngka1.Text.All(Char.IsNumber))
                {
                    SetErrorMessages(txtAngka1, "", "", "Betul!");
                }
            }
        }
    }
}


