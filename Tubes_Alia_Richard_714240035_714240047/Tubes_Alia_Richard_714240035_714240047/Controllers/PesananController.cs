using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tubes_Alia_Richard_714240035_714240047.Database;
using Tubes_Alia_Richard_714240035_714240047.Models;

namespace Tubes_Alia_Richard_714240035_714240047.Controllers
{
    public class PesananController
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        // Create Pesanan Baru
        public int CreatePesanan(Pesanan pesanan, List<KeranjangItem> items)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert pesanan
                        string queryPesanan = @"INSERT INTO pesanan (user_id, total_harga, status, alamat_pengiriman, catatan) 
                                               VALUES (@userid, @total, @status, @alamat, @catatan)";
                        
                        MySqlCommand cmdPesanan = new MySqlCommand(queryPesanan, conn, transaction);
                        cmdPesanan.Parameters.AddWithValue("@userid", pesanan.UserId);
                        cmdPesanan.Parameters.AddWithValue("@total", pesanan.TotalHarga);
                        cmdPesanan.Parameters.AddWithValue("@status", "Pending");
                        cmdPesanan.Parameters.AddWithValue("@alamat", pesanan.AlamatPengiriman);
                        cmdPesanan.Parameters.AddWithValue("@catatan", pesanan.Catatan ?? "");
                        cmdPesanan.ExecuteNonQuery();

                        // Get last inserted ID
                        int pesananId = (int)cmdPesanan.LastInsertedId;

                        // Insert detail pesanan
                        foreach (var item in items)
                        {
                            string queryDetail = @"INSERT INTO detail_pesanan (pesanan_id, produk_id, nama_produk, harga, jumlah, subtotal) 
                                                  VALUES (@pesananid, @produkid, @nama, @harga, @jumlah, @subtotal)";
                            
                            MySqlCommand cmdDetail = new MySqlCommand(queryDetail, conn, transaction);
                            cmdDetail.Parameters.AddWithValue("@pesananid", pesananId);
                            cmdDetail.Parameters.AddWithValue("@produkid", item.ProdukId);
                            cmdDetail.Parameters.AddWithValue("@nama", item.NamaProduk);
                            cmdDetail.Parameters.AddWithValue("@harga", item.Harga);
                            cmdDetail.Parameters.AddWithValue("@jumlah", item.Jumlah);
                            cmdDetail.Parameters.AddWithValue("@subtotal", item.Subtotal);
                            cmdDetail.ExecuteNonQuery();

                            // Update stok produk
                            string updateStok = "UPDATE produk SET stok = stok - @jumlah WHERE produk_id = @produkid";
                            MySqlCommand cmdStok = new MySqlCommand(updateStok, conn, transaction);
                            cmdStok.Parameters.AddWithValue("@jumlah", item.Jumlah);
                            cmdStok.Parameters.AddWithValue("@produkid", item.ProdukId);
                            cmdStok.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return pesananId;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Create Pesanan: " + ex.Message);
                return -1;
            }
        }

        // Get All Pesanan (Admin)
        public DataTable GetAllPesanan()
        {
            try
            {
                string query = @"SELECT p.pesanan_id AS 'ID', u.full_name AS 'Pelanggan', 
                               DATE_FORMAT(p.tanggal_pesan, '%d/%m/%Y %H:%i') AS 'Tanggal', 
                               p.total_harga AS 'Total', p.status AS 'Status',
                               p.alamat_pengiriman AS 'Alamat'
                               FROM pesanan p
                               JOIN users u ON p.user_id = u.user_id
                               ORDER BY p.tanggal_pesan DESC";
                
                return dbConnection.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Get Pesanan: " + ex.Message);
                return new DataTable();
            }
        }

        // Get Pesanan by User ID
        public DataTable GetPesananByUserId(int userId)
        {
            try
            {
                string query = @"SELECT pesanan_id AS 'ID', 
                               DATE_FORMAT(tanggal_pesan, '%d/%m/%Y %H:%i') AS 'Tanggal', 
                               total_harga AS 'Total', status AS 'Status'
                               FROM pesanan
                               WHERE user_id = @userid
                               ORDER BY tanggal_pesan DESC";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@userid", userId)
                };

                return dbConnection.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return new DataTable();
            }
        }

        // Get Pesanan Detail
        public Pesanan GetPesananById(int pesananId)
        {
            try
            {
                string query = @"SELECT p.*, u.full_name AS nama_user 
                               FROM pesanan p
                               JOIN users u ON p.user_id = u.user_id
                               WHERE p.pesanan_id = @pesananid";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@pesananid", pesananId)
                };

                DataTable dt = dbConnection.ExecuteQuery(query, parameters);
                
                if (dt.Rows.Count > 0)
                {
                    return new Pesanan
                    {
                        PesananId = Convert.ToInt32(dt.Rows[0]["pesanan_id"]),
                        UserId = Convert.ToInt32(dt.Rows[0]["user_id"]),
                        NamaUser = dt.Rows[0]["nama_user"].ToString(),
                        TanggalPesan = Convert.ToDateTime(dt.Rows[0]["tanggal_pesan"]),
                        TotalHarga = Convert.ToDecimal(dt.Rows[0]["total_harga"]),
                        Status = dt.Rows[0]["status"].ToString(),
                        AlamatPengiriman = dt.Rows[0]["alamat_pengiriman"].ToString(),
                        Catatan = dt.Rows[0]["catatan"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        // Get Detail Items of Pesanan
        public List<DetailPesanan> GetDetailPesanan(int pesananId)
        {
            List<DetailPesanan> details = new List<DetailPesanan>();
            try
            {
                string query = @"SELECT * FROM detail_pesanan WHERE pesanan_id = @pesananid";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@pesananid", pesananId)
                };

                DataTable dt = dbConnection.ExecuteQuery(query, parameters);
                
                foreach (DataRow row in dt.Rows)
                {
                    details.Add(new DetailPesanan
                    {
                        DetailId = Convert.ToInt32(row["detail_id"]),
                        PesananId = Convert.ToInt32(row["pesanan_id"]),
                        ProdukId = Convert.ToInt32(row["produk_id"]),
                        NamaProduk = row["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(row["harga"]),
                        Jumlah = Convert.ToInt32(row["jumlah"]),
                        Subtotal = Convert.ToDecimal(row["subtotal"])
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return details;
        }

        // Update Status Pesanan
        public bool UpdateStatus(int pesananId, string status)
        {
            try
            {
                string query = "UPDATE pesanan SET status = @status WHERE pesanan_id = @pesananid";
                
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@status", status),
                    new MySqlParameter("@pesananid", pesananId)
                };

                return dbConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update Status: " + ex.Message);
                return false;
            }
        }

        // Filter by Status
        public DataTable FilterByStatus(string status)
        {
            try
            {
                string query = @"SELECT p.pesanan_id AS 'ID', u.full_name AS 'Pelanggan', 
                               DATE_FORMAT(p.tanggal_pesan, '%d/%m/%Y %H:%i') AS 'Tanggal', 
                               p.total_harga AS 'Total', p.status AS 'Status'
                               FROM pesanan p
                               JOIN users u ON p.user_id = u.user_id
                               WHERE p.status = @status
                               ORDER BY p.tanggal_pesan DESC";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@status", status)
                };

                return dbConnection.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return new DataTable();
            }
        }

        // Get Order Statistics (for Dashboard)
        public Dictionary<string, object> GetOrderStatistics()
        {
            Dictionary<string, object> stats = new Dictionary<string, object>();
            try
            {
                // Total Pesanan
                object totalPesanan = dbConnection.ExecuteScalar("SELECT COUNT(*) FROM pesanan");
                stats["TotalPesanan"] = Convert.ToInt32(totalPesanan);

                // Pesanan Pending
                object pending = dbConnection.ExecuteScalar("SELECT COUNT(*) FROM pesanan WHERE status = 'Pending'");
                stats["Pending"] = Convert.ToInt32(pending);

                // Pesanan Diproses
                object diproses = dbConnection.ExecuteScalar("SELECT COUNT(*) FROM pesanan WHERE status = 'Diproses'");
                stats["Diproses"] = Convert.ToInt32(diproses);

                // Pesanan Selesai Hari Ini
                object selesaiHariIni = dbConnection.ExecuteScalar(
                    "SELECT COUNT(*) FROM pesanan WHERE status = 'Selesai' AND DATE(tanggal_pesan) = CURDATE()");
                stats["SelesaiHariIni"] = Convert.ToInt32(selesaiHariIni);

                // Pendapatan Total
                object pendapatanTotal = dbConnection.ExecuteScalar(
                    "SELECT COALESCE(SUM(total_harga), 0) FROM pesanan WHERE status = 'Selesai'");
                stats["PendapatanTotal"] = Convert.ToDecimal(pendapatanTotal);

                // Pendapatan Hari Ini
                object pendapatanHariIni = dbConnection.ExecuteScalar(
                    "SELECT COALESCE(SUM(total_harga), 0) FROM pesanan WHERE status = 'Selesai' AND DATE(tanggal_pesan) = CURDATE()");
                stats["PendapatanHariIni"] = Convert.ToDecimal(pendapatanHariIni);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Get Order Statistics: " + ex.Message);
            }
            return stats;
        }

        // Cancel Pesanan (untuk user atau admin)
        public bool CancelPesanan(int pesananId)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Get detail pesanan untuk restore stok
                        string queryDetail = "SELECT produk_id, jumlah FROM detail_pesanan WHERE pesanan_id = @pesananid";
                        MySqlCommand cmdDetail = new MySqlCommand(queryDetail, conn, transaction);
                        cmdDetail.Parameters.AddWithValue("@pesananid", pesananId);
                        
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmdDetail))
                        {
                            adapter.Fill(dt);
                        }

                        // Restore stok
                        foreach (DataRow row in dt.Rows)
                        {
                            string updateStok = "UPDATE produk SET stok = stok + @jumlah WHERE produk_id = @produkid";
                            MySqlCommand cmdStok = new MySqlCommand(updateStok, conn, transaction);
                            cmdStok.Parameters.AddWithValue("@jumlah", Convert.ToInt32(row["jumlah"]));
                            cmdStok.Parameters.AddWithValue("@produkid", Convert.ToInt32(row["produk_id"]));
                            cmdStok.ExecuteNonQuery();
                        }

                        // Update status pesanan
                        string updateStatus = "UPDATE pesanan SET status = 'Dibatalkan' WHERE pesanan_id = @pesananid";
                        MySqlCommand cmdStatus = new MySqlCommand(updateStatus, conn, transaction);
                        cmdStatus.Parameters.AddWithValue("@pesananid", pesananId);
                        cmdStatus.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cancel Pesanan: " + ex.Message);
                return false;
            }
        }
    }
}
