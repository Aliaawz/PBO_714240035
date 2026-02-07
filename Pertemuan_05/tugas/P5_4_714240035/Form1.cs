using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi nama
            string nama = maskedTextBox1.Text;
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama belum diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi jenis kelamin
            string gender = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(gender) || gender == "--Pilih Jenis Kelamin--")
            {
                MessageBox.Show("Jenis kelamin belum dipilih!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ambil tanggal lahir
            string tglLahir = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            // Validasi pilihan jadwal (RadioButton)
            string selectedJadwal = "";
            foreach (Control ctrl in jadwal.Controls) // GroupBox 'jadwal'
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    selectedJadwal = rb.Text;
                    break;
                }
            }

            if (string.IsNullOrEmpty(selectedJadwal))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi pilihan kelas (CheckBox)
            StringBuilder selectedKelas = new StringBuilder();
            foreach (Control ctrl in kelas.Controls) // GroupBox 'kelas'
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    selectedKelas.Append(cb.Text + ", ");
                }
            }

            string kelasValue = selectedKelas.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrEmpty(kelasValue))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan data
            MessageBox.Show(
                $"Nama           : {nama}\n" +
                $"Jenis Kelamin  : {gender}\n" +
                $"Tanggal Lahir  : {tglLahir}\n" +
                $"Pilihan Kelas  : {kelasValue}\n" +
                $"Jadwal         : {selectedJadwal}",
                "Data Pendaftaran",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

