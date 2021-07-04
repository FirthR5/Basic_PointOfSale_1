using Prj_Data;
using Prj_Ent;
using System.Data;

namespace Prj_Business
{
    public class RN_Products
    {
        public DataTable showProducts()
        {
            BD_Products obj = new BD_Products();
            return obj.BD_ShowProducts();
        }
        public void RegisterProducts(EN_Prod Prod)
        {
            BD_Products obj = new BD_Products();
            obj.BD_RegisterProducts(Prod);
        }

    }
}
