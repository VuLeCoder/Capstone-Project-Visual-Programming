using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormProduct.Classes
{
    internal class DataProcesser
    {
        private readonly string dbName = "Schedule";
        private readonly string serverName = @"TRIPLEK\SQLEXPRESS";
        private string connectionString =>
            $@"Server={serverName};Database={dbName};Trusted_Connection=True;";


        public DataTable ReadTable(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu:\n" + ex.Message, "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu:\n" + ex.Message, "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rowsAffected;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy giá trị:\n" + ex.Message, "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
