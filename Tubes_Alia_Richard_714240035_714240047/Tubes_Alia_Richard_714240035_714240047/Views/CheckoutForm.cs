using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tubes_Alia_Richard_714240035_714240047.Controllers;
using Tubes_Alia_Richard_714240035_714240047.Helpers;
using Tubes_Alia_Richard_714240035_714240047.Models;

namespace Tubes_Alia_Richard_714240035_714240047.Views
{
    public class CheckoutForm : Form
    {
        private PesananController pesananController = new PesananController();
        private int userId;
        private TextBox txtAlamat;
        private TextBox txtCatatan;
        private Label lblTotal;

        public CheckoutForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            LoadOrderSummary();
        }

        private void InitializeComponent()
        {
            this.Text = "Checkout";
            this.Width = 800;
            this.Height = 650;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Header
            Panel pnlHeader = UIHelper.CreateHeader("💳 CHECKOUT", this.Width);
            this.Controls.Add(pnlHeader);

            // Order Summary Panel
            Panel pnlSummary = new Panel
            {
                Left = 15,
                Top = 60,
                Width = 760,
                Height = 200,
                BackColor = Color.White
            };

            Label lblSummaryTitle = new Label
            {
                Text = "📋 Ringkasan Pesanan",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Left = 15,
                Top = 15,
                AutoSize = true
            };

            DataGridView dgvSummary = new DataGridView
            {
                Left = 15,
                Top = 50,
                Width = 730,
                Height = 130
            };
            UIHelper.StyleDataGridView(dgvSummary);

            // Setup columns
            dgvSummary.Columns.Add("Produk", "Produk");
            dgvSummary.Columns.Add("Harga", "Harga");
            dgvSummary.Columns.Add("Qty", "Qty");
            dgvSummary.Columns.Add("Subtotal", "Subtotal");

            if (UserMainForm.Keranjang != null)
            {
                foreach (var item in UserMainForm.Keranjang)
                {
                    dgvSummary.Rows.Add(
                        item.NamaProduk,
                        UIHelper.FormatCurrency(item.Harga),
                        item.Jumlah,
                        UIHelper.FormatCurrency(item.Subtotal)
                    );
                }
            }

            pnlSummary.Controls.Add(lblSummaryTitle);
            pnlSummary.Controls.Add(dgvSummary);
            this.Controls.Add(pnlSummary);

            // Shipping Info Panel
            Panel pnlShipping = new Panel
            {
                Left = 15,
                Top = 270,
                Width = 760,
                Height = 180,
                BackColor = Color.White
            };

            Label lblShippingTitle = new Label
            {
                Text = "📍 Informasi Pengiriman",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Left = 15,
                Top = 15,
                AutoSize = true
            };

            Label lblAlamatLabel = new Label
            {
                Text = "Alamat Pengiriman: *",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Left = 15,
                Top = 50,
                AutoSize = true
            };

            txtAlamat = new TextBox
            {
                Left = 15,
                Top = 75,
                Width = 730,
                Height = 40,
                Multiline = true,
                Font = new Font("Segoe UI", 10),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblCatatanLabel = new Label
            {
                Text = "Catatan (opsional):",
                Font = new Font("Segoe UI", 10),
                Left = 15,
                Top = 125,
                AutoSize = true
            };

            txtCatatan = new TextBox
            {
                Left = 15,
                Top = 145,
                Width = 730,
                Height = 30,
                Font = new Font("Segoe UI", 10),
                BorderStyle = BorderStyle.FixedSingle
            };

            pnlShipping.Controls.Add(lblShippingTitle);
            pnlShipping.Controls.Add(lblAlamatLabel);
            pnlShipping.Controls.Add(txtAlamat);
            pnlShipping.Controls.Add(lblCatatanLabel);
            pnlShipping.Controls.Add(txtCatatan);
            this.Controls.Add(pnlShipping);

            // Total Panel
            Panel pnlTotal = new Panel
            {
                Left = 15,
                Top = 460,
                Width = 760,
                Height = 80,
                BackColor = UIHelper.PrimaryColor
            };

            Label lblTotalTitle = new Label
            {
                Text = "TOTAL PEMBAYARAN",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Left = 20,
                Top = 15,
                AutoSize = true
            };

            lblTotal = new Label
            {
                Text = "Rp 0",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                Left = 20,
                Top = 38,
                AutoSize = true
            };

            Button btnKonfirmasi = new Button
            {
                Text = "✓ KONFIRMASI PESANAN",
                Left = 530,
                Top = 20,
                Width = 210,
                Height = 45,
                BackColor = UIHelper.SuccessColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnKonfirmasi.FlatAppearance.BorderSize = 0;
            btnKonfirmasi.Click += BtnKonfirmasi_Click;

            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(btnKonfirmasi);
            this.Controls.Add(pnlTotal);

            // Cancel Button
            Button btnBatal = new Button
            {
                Text = "← Kembali",
                Left = 15,
                Top = 555,
                Width = 120,
                Height = 40
            };
            UIHelper.StyleButton(btnBatal, UIHelper.DarkColor);
            btnBatal.Click += (s, e) => this.Close();
            this.Controls.Add(btnBatal);

            // Info
            Label lblInfo = new Label
            {
                Text = "💡 Pembayaran dilakukan secara COD (Cash on Delivery)",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                Left = 150,
                Top = 565,
                AutoSize = true
            };
            this.Controls.Add(lblInfo);
        }

        private void LoadOrderSummary()
        {
            decimal total = UserMainForm.Keranjang.Sum(k => k.Subtotal);
            lblTotal.Text = UIHelper.FormatCurrency(total);
        }

        private void BtnKonfirmasi_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Alamat pengiriman wajib diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlamat.Focus();
                return;
            }

            if (UserMainForm.Keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm
            if (MessageBox.Show("Yakin ingin melakukan pemesanan?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // Create order
            Pesanan pesanan = new Pesanan
            {
                UserId = userId,
                TotalHarga = UserMainForm.Keranjang.Sum(k => k.Subtotal),
                AlamatPengiriman = txtAlamat.Text.Trim(),
                Catatan = txtCatatan.Text.Trim()
            };

            int pesananId = pesananController.CreatePesanan(pesanan, UserMainForm.Keranjang.ToList());

            if (pesananId > 0)
            {
                MessageBox.Show($"🎉 Pesanan berhasil dibuat!\n\n" +
                    $"ID Pesanan: #{pesananId}\n" +
                    $"Total: {UIHelper.FormatCurrency(pesanan.TotalHarga)}\n" +
                    $"Status: Pending\n\n" +
                    $"Silakan tunggu konfirmasi dari admin.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear cart
                UserMainForm.Keranjang.Clear();
                this.Close();
            }
        }
    }
}
