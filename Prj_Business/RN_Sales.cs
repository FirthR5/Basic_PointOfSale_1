using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Data;

namespace Prj_Business
{
    public class RN_Sales
    {
        public DataTable RN_Sales_Stock()
        {
            DB_Sales obj = new DB_Sales();
            return obj.DB_Sales_Stock();
        }
        public DataTable RN_SearchProductByID(int IdProd)
        {
            DB_Sales obj =new DB_Sales();
            return obj.DB_SearchProductByID(IdProd);
        }
    }
}
