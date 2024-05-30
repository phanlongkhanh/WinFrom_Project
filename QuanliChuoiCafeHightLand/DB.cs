using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliChuoiCafeHightLand
{
     public class DB
    {
        public static string ConnectString = @"Data Source=DESKTOP-BVRCBVV\MSSQLSERVER01;Initial Catalog=DoAnQuanLiChuoiCuaHangHighLandCoffee;Integrated Security=True";
        SqlConnection conn = null;
       

        public DataTable Laydulieu(string sql)
        {
            SqlDataAdapter data;
            DataTable ds = new DataTable();
            try 
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                data = new SqlDataAdapter(command);
                data.Fill(ds);

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Kết Nối" + e.Message);
            }
            finally
            { 
                conn.Close();
            }
            return ds;  
        }  
    }
}
