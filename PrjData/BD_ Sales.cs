using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Data
{
    public class DB_Sales : BD_Connection
    {
        public DataTable DB_Sales_Stock()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;
                SqlDataAdapter da = new SqlDataAdapter("Sp_Sales_Stock", cn);
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
        public DataTable DB_SearchProductByID(int IdProd)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Connection1;
                SqlDataAdapter da = new SqlDataAdapter("Sp_FindProduct", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Product_Id", IdProd);
                DataTable data = new DataTable();

                da.Fill(data);

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
