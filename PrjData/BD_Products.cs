using System;
using System.Data;
using System.Data.SqlClient;
using Prj_Ent;

namespace Prj_Data
{
    public class BD_Products : BD_Connection
    {
        public DataTable BD_ShowProducts()
        {
            //ToDo: Show Products
            //Sp_ViewProducts
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;
                SqlDataAdapter da = new SqlDataAdapter("Sp_ViewProducts", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable data = new DataTable();
                da.Fill(data);
                da = null; 

                return data;
            }
            catch (Exception ex)
            {

                string msm1 = ex.Message;
            }

            return null;
        }
        public void BD_RegisterProducts(EN_Prod Prod)
        {
            SqlConnection cn = new SqlConnection();
            try
            { 
                string x;
                cn.ConnectionString = Connection1;
                SqlCommand cmd = new SqlCommand("Sp_RegisterProduct", cn);
                
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Category_Id", Prod.Category_Id);
                cmd.Parameters.AddWithValue("@Brand_Id", Prod.Brand_Id);
                cmd.Parameters.AddWithValue("@Product_Name", Prod.Product_Name);
                cmd.Parameters.AddWithValue("@Quantity", Prod.Quantity);
                cmd.Parameters.AddWithValue("@Price", Prod.Price);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
        public DataTable DB_Stock()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;
                SqlDataAdapter da = new SqlDataAdapter("Sp_Stock", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable data = new DataTable();
                da.Fill(data);
                da = null;
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
