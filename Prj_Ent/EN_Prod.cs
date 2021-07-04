using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Ent
{
    public class EN_Prod
    {
        //Sp_RegisterProduct
        //@Product_Id,
        //@Category_Id,
        //@Brand_Id,
        //@Product_Name,
        //@Quantity,
        //@Price
        private int product_Id, category_Id, brand_Id, auantity;
        private double price;
        private string product_Name;

        public int Product_Id       { get => product_Id; set => product_Id = value; }
        public int Category_Id      { get => category_Id; set => category_Id = value; }
        public int Brand_Id         { get => brand_Id; set => brand_Id = value; }
        public int Quantity         { get => auantity; set => auantity = value; }
        public double Price         { get => price; set => price = value; }
        public string Product_Name  { get => product_Name; set => product_Name = value; }
    }
}
