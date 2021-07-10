using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Business;
using System.Windows.Forms;

namespace PointOfSale_1
{
    public partial class UC_Report : UserControl
    {
        public UC_Report()
        {
            InitializeComponent();
        }



        private void UC_Report_Load(object sender, EventArgs e)
        {
            lsv_Sett();
            lsvTable();
        }


        #region lsv
        public void lsvTable()
        {
            RN_Products obj = new RN_Products();
            DataTable data = new DataTable();
            try
            {
                data = obj.RN_Stock();
                lsvLoad(data);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void lsvLoad(DataTable table)
        {
            lsv_Prod.Items.Clear();
            for (int i = 0; i <table.Rows.Count; i++)
            {
                DataRow dr = table.Rows[i];
                ListViewItem list = new ListViewItem(dr["Product_Name"].ToString());
                list.SubItems.Add(dr["Quantity"].ToString());
                lsv_Prod.Items.Add(list);
            }
           customTable();
            stock.Text = lsv_Prod.Items.Count.ToString();
        }
        public void customTable()
        {
            foreach(ListViewItem item in lsv_Prod.Items)
            {
                item.BackColor = (item.Index % 2) == 0 ? Color.White : Color.WhiteSmoke;
                item.Font = new System.Drawing.Font("Oxygen", 11);
            }
        }
        public void lsv_Sett()
        {
            var lis = lsv_Prod;

            lsv_Prod.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            lis.Columns.Add("Product name", 294);
            lis.Columns.Add("Stock", 50);

        }

        #endregion



        //ID, Stock
    }
}
