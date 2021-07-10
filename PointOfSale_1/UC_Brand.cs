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
    public partial class UC_Brand : UserControl
    {
        public UC_Brand()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            RN_Brand obj = new RN_Brand();
            string brandName = txtBrand.Text;
            if (brandName.Length > 0)
            {
                obj.RegisterBrand(brandName);
                LsvData();
            }
        }

        

       
        #region List_
        private void LsvData()
        {

            RN_Brand obj = new RN_Brand();
            DataTable data_ = new DataTable();
            try
            {
                data_ = obj.ShowBrands();
                LVLoad(data_);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LVLoad(DataTable data)
        {
            lsv_Brand.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Br"].ToString());
                list.SubItems.Add(dr["Brand_Name"].ToString());
                lsv_Brand.Items.Add(list);

            }
            CustomTable();
            lblstock.Text = lsv_Brand.Items.Count.ToString();
        }
        private void ListViewSett()
        {
            var lis = lsv_Brand;

            lsv_Brand.Items.Clear();

            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            lis.CheckBoxes = true;
            lis.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            
            
            //lis
            
            //TODO DELETE
            lis.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lis.Columns.Add("Name", 250, HorizontalAlignment.Left);
        }



        #endregion

        private void UC_Brand_Load(object sender, EventArgs e)
        {
            ListViewSett();
            LsvData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RN_Brand obj = new RN_Brand();
            if (this.lsv_Brand.CheckedIndices.Count > 0)
            {
                int x = lsv_Brand.CheckedIndices.Count;
                string[] xd = new string[x];

                for (int i = lsv_Brand.CheckedIndices.Count - 1; i >= 0; i--)
                {
                    var lisw = lsv_Brand.CheckedIndices[i];
                    xd[i] = lisw.ToString();
                }

                //Remove: this.lsv_Prod.Items.RemoveAt(this.lsv_Prod.CheckedIndices[i]);
                //Read Indexes by row: lsv_Brand.Items[i].Index;

                for (int o = lsv_Brand.CheckedIndices.Count - 1; o >= 0; o--)
                {
                    for (int i = 0; i < lsv_Brand.Items.Count; i++)
                        if (lsv_Brand.Items[i].Index == Convert.ToInt32(xd[o]))
                        {
                            var lis = lsv_Brand.Items[i];
                            int id = Convert.ToInt32(lis.SubItems[0].Text);

                            obj.RN_Remove_Brand(id);
                        }
                }
                LsvData();
            }
        }
        private void CustomTable()
        {

            //lsv_Brand.BackColor = Color.White;
            //for(int i =0; i<lsv_Brand.Items.Count; i++)
            //{
            //    if ((i % 2) == 0)
            //        lsv_Brand.Items[i].BackColor = Color.GhostWhite;
            //    lsv_Brand.Items[i].Font = new System.Drawing.Font("Oxygen", 10);
            //}
            foreach (ListViewItem item in lsv_Brand.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.GhostWhite : Color.White;
                item.Font = new System.Drawing.Font("Oxygen", 10);
            }
        }
    }
}
