using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang.Classes
{
    public class DatabaseProcessing
    {
        // Sửa lại đúng tên Server của máy bạn (xem trong SSMS)
        string connectString = "Server=.\\SQLEXPRESS;Database=HangHoa;Integrated Security=true";
        SqlConnection conn = null;

        // Phương thức mở kết nối
        void OpenConnect()
        {
            conn = new SqlConnection(connectString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        // Phương thức đóng kết nối
        void CloseConnect()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        // Phương thức thực hiện lệnh select, trả về DataTable để đổ lên DataGridView
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conn);
            adapter.Fill(dt);
            CloseConnect();
            return dt;
        }

        // Phương thức thực thi lệnh insert, update hoặc delete (Trả về true/false)
        public bool ChangeData(string sql)
        {
            try
            {
                OpenConnect();
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = conn;
                sqlcomm.CommandText = sql;

                int rows = sqlcomm.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                CloseConnect();

                return rows > 0; // Trả về true nếu thực thi thành công
            }
            catch (Exception)
            {
                CloseConnect();
                return false; // Trả về false nếu gặp lỗi SQL
            }
        }
    }
}