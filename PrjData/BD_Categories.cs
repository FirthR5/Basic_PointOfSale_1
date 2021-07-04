using Prj_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjData
{
    public class BD_Categories : BD_Connection
    {
        public DataTable BD_ShowCategories()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;

                SqlDataAdapter da = new SqlDataAdapter("Sp_ViewCategory", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable data = new DataTable();

                da.Fill(data);
                da = null;

                return data;
            }
            catch (Exception ex)
            {
                string msm = ex.Message;
                return null;
            }
        }
        public void BD_RegisterCategory(string CatName)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;
                SqlCommand cmd = new SqlCommand("Sp_Register_Category", cn);

                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_Name", CatName);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }

        }
        public void BD_RemoveCategory(int Id_Cat)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;
                SqlCommand cmd = new SqlCommand("Sp_Delete_Category", cn);

                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cat", Id_Cat);


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
