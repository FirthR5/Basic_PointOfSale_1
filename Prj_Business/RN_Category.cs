using PrjData;
using System.Data;

namespace Prj_Business
{
    public class RN_Category
    {
        public DataTable RN_ShowCategories()
        {
            BD_Categories obj = new BD_Categories();
            return obj.BD_ShowCategories();
        }
        public void RN_RegisterCategory(string CatName)
        {
            BD_Categories obj = new BD_Categories();
            obj.BD_RegisterCategory(CatName);
        }
        public void RN_RemoveCategory(int Id_Cat)
        {
            BD_Categories obj = new BD_Categories();
            obj.BD_RemoveCategory(Id_Cat);
        }
    }
}
