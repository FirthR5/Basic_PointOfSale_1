using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Data
{
    public class BD_Brand : BD_Connection
    {
        public DataTable BD_ShowBrands()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;

                SqlDataAdapter da = new SqlDataAdapter("Sp_ViewBrands", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable data = new DataTable();

                da.Fill(data);
                da = null;
                return data;
            }
            catch (Exception ex)
            {
                string x = ex.Message;
                return null;
            }
        }
        public void BD_RegisterBrand(string BrandName)
        {
            //Sp_Register_Brand
            // @Id_Br INT,
            //@Brand_Name VARCHAR(20)
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;

                SqlCommand cmd = new SqlCommand("Sp_Register_Brand", cn);


                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Brand_Name", BrandName);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }

        }

        public void BD_Remove_Brand(int Id_Br)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;

                SqlCommand cmd = new SqlCommand("Sp_Delete_Brand", cn);

                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Br", Id_Br);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
    
}
