using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; // đung de truy van cau lenh insert update delete 
        SqlDataReader sqlReader; // dung de doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read()) 
                {
                    taiKhoans.Add(new TaiKhoan(sqlReader.GetString(0), sqlReader.GetString(1)));

                }

                sqlConnection.Close();

            }
                return taiKhoans;
        }
        public void Command(string query)//dung de dang ky taikhoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thuc hien cau lenh truy van 
                sqlConnection.Close();
            }
        }
    }
}
