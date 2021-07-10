using Prj_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1
{
    public partial class UC_ProductCategory : UserControl
    {
        public UC_ProductCategory()
        {
            InitializeComponent();
        }

        private void UC_ProductCategory_Load(object sender, EventArgs e)
        {
            ListViewSett();
            LsvData();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            RN_Category obj = new RN_Category();
            try
            {
                string Cat = txtCategoryName.Text;

                obj.RN_RegisterCategory(Cat);
            }
            catch (Exception ex)
            {

                throw;
            }

            LsvData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RN_Category obj = new RN_Category();
            if (this.lsv_Cat.CheckedIndices.Count > 0)
            {
                int x = lsv_Cat.CheckedIndices.Count;
                string[] xd = new string[x];
                for (int i = lsv_Cat.CheckedIndices.Count - 1; i >= 0; i--)
                {
                    var lisw = lsv_Cat.CheckedIndices[i];
                    xd[i] = lisw.ToString();
                }

                for (int o = lsv_Cat.CheckedIndices.Count - 1; o >= 0; o--)
                {
                    for (int i = 0; i < lsv_Cat.Items.Count; i++)
                    {
                        if (lsv_Cat.Items[i].Index == Convert.ToInt32(xd[o]))
                        {
                            var lis = lsv_Cat.Items[i];
                            int id = Convert.ToInt32(lis.SubItems[0].Text);

                            obj.RN_RemoveCategory(id);
                        }
                    }
                }
            }
            LsvData();
        }

        private void LsvData()
        {
            RN_Category obj = new RN_Category();
            DataTable data_ = new DataTable();

            try
            {
                data_ = obj.RN_ShowCategories();
                LsvLoad(data_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void LsvLoad(DataTable data)
        {
            lsv_Cat.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Cat"].ToString());
                list.SubItems.Add(dr["Cat_Name"].ToString());
                lsv_Cat.Items.Add(list);
            }
        }
        private void ListViewSett()
        {
            var lis = lsv_Cat;

            lsv_Cat.Items.Clear();

            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = true;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            lis.CheckBoxes = true;

            lis.Columns.Add("ID", 100, HorizontalAlignment.Center);
            lis.Columns.Add("Category Name", 100, HorizontalAlignment.Left);
        }
    }
}
