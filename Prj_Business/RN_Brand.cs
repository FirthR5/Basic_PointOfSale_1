using System;
using Prj_Data;
using System.Data;

namespace Prj_Business
{
    public class RN_Brand
    {
        public DataTable ShowBrands()
        {
            BD_Brand obj = new BD_Brand();
            return obj.BD_ShowBrands();
        }
        public void RegisterBrand(string BrandName)
        {
            BD_Brand obj = new BD_Brand();
            obj.BD_RegisterBrand(BrandName);
        }
        public void RN_Remove_Brand(int Id_Br)
        {
            BD_Brand obj = new BD_Brand();
            obj.BD_Remove_Brand(Id_Br);
        }

    }
}
