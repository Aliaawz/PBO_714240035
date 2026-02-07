using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tubes_Alia_Richard_714240035_714240047.Controllers;
using Tubes_Alia_Richard_714240035_714240047.Helpers;

namespace Tubes_Alia_Richard_714240035_714240047.Views
{
    public class DashboardForm : Form
    {
        private ProdukController produkController = new ProdukController();
        private PesananController pesananController = new PesananController();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Dashboard";
            this.Width = 1100;
            this.Height = 700;
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Panel Header
            Panel pnlHeader = UIHelper.CreateHeader("📊 DASHBOARD ADMIN", this.Width);
            this.Controls.Add(pnlHeader);

            // Main Panel
            Panel pnlMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(240, 240, 240),
                Padding = new Padding(20),
                AutoScroll = true
            };

            // Get Statistics
            Dictionary<string, object> produkStats = produkController.GetStatistics();
            Dictionary<string, object> orderStats = pesananController.GetOrderStatistics();

            // Row 1: Produk Stats
            Label lblProdukSection = new Label
            {
                Text = "📦 STATISTIK PRODUK",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = UIHelper.DarkColor,
                Left = 20,
                Top = 60,
                AutoSize = true
            };

            Panel card1 = UIHelper.CreateStatCard("Total Produk", produkStats["TotalProduk"].ToString(), 
                UIHelper.SecondaryColor, 20, 90);
            Panel card2 = UIHelper.CreateStatCard("Total Kategori", produkStats["TotalKategori"].ToString(), 
                UIHelper.SuccessColor, 320, 90);
            Panel card3 = UIHelper.CreateStatCard("Total Stok", produkStats["TotalStok"].ToString(), 
                UIHelper.InfoColor, 620, 90);

            // Row 2: More Produk Stats
            Panel card4 = UIHelper.CreateStatCard("Nilai Inventory", 
                UIHelper.FormatCurrency(Convert.ToDecimal(produkStats["TotalNilai"])), 
                UIHelper.OrangeColor, 20, 245);
            Panel card5 = UIHelper.CreateStatCard("Stok Rendah", produkStats["LowStock"].ToString(), 
                UIHelper.DangerColor, 320, 245);
            Panel card6 = UIHelper.CreateStatCard("Harga Rata-rata", 
                UIHelper.FormatCurrency(Convert.ToDecimal(produkStats["AvgHarga"])), 
                UIHelper.DarkColor, 620, 245);

            // Row 3: Order Stats
            Label lblOrderSection = new Label
            {
                Text = "📋 STATISTIK PESANAN",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = UIHelper.DarkColor,
                Left = 20,
                Top = 400,
                AutoSize = true
            };

            int totalPesanan = orderStats.ContainsKey("TotalPesanan") ? Convert.ToInt32(orderStats["TotalPesanan"]) : 0;
            int pending = orderStats.ContainsKey("Pending") ? Convert.ToInt32(orderStats["Pending"]) : 0;
            decimal pendapatan = orderStats.ContainsKey("PendapatanTotal") ? Convert.ToDecimal(orderStats["PendapatanTotal"]) : 0;

            Panel card7 = UIHelper.CreateStatCard("Total Pesanan", totalPesanan.ToString(), 
                UIHelper.PrimaryColor, 20, 430);
            Panel card8 = UIHelper.CreateStatCard("Pesanan Pending", pending.ToString(), 
                UIHelper.WarningColor, 320, 430);
            Panel card9 = UIHelper.CreateStatCard("Total Pendapatan", 
                UIHelper.FormatCurrency(pendapatan), 
                UIHelper.SuccessColor, 620, 430);

            // Button Refresh
            Button btnRefresh = new Button
            {
                Text = "🔄 REFRESH DATA",
                Left = 20,
                Top = 590,
                Width = 150,
                Height = 40
            };
            UIHelper.StyleButton(btnRefresh, UIHelper.PrimaryColor);
            btnRefresh.Click += (s, e) =>
            {
                this.Close();
                DashboardForm newDashboard = new DashboardForm();
                newDashboard.MdiParent = this.MdiParent;
                newDashboard.Show();
            };

            // Info Label
            Label lblInfo = new Label
            {
                Text = "💡 Statistik real-time mengenai inventori dan pesanan",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                Left = 190,
                Top = 600,
                AutoSize = true
            };

            pnlMain.Controls.Add(lblProdukSection);
            pnlMain.Controls.Add(card1);
            pnlMain.Controls.Add(card2);
            pnlMain.Controls.Add(card3);
            pnlMain.Controls.Add(card4);
            pnlMain.Controls.Add(card5);
            pnlMain.Controls.Add(card6);
            pnlMain.Controls.Add(lblOrderSection);
            pnlMain.Controls.Add(card7);
            pnlMain.Controls.Add(card8);
            pnlMain.Controls.Add(card9);
            pnlMain.Controls.Add(btnRefresh);
            pnlMain.Controls.Add(lblInfo);

            this.Controls.Add(pnlMain);
        }

        private Panel CreateStatCard(string title, string value, Color bgColor, int left, int top)
        {
            Panel card = new Panel
            {
                Left = left,
                Top = top,
                Width = 280,
                Height = 150,
                BackColor = bgColor,
                BorderStyle = BorderStyle.None,
                Cursor = Cursors.Hand
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Left = 15,
                Top = 20
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Arial", 28, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Left = 15,
                Top = 50
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(200, 200, 200), 1), 0, 0, card.Width - 1, card.Height - 1);
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }
    }
}