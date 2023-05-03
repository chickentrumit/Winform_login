using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Connection
    {
        private static string stringConnection= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c#\programming winform\WindowsFormsApp2\WindowsFormsApp2\datadangnhap.mdf"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
    }
}
