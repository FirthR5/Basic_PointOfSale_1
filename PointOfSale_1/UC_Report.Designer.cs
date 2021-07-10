
namespace PointOfSale_1
{
    partial class UC_Report
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsv_Prod = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(311, 551);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(13, 13);
            this.stock.TabIndex = 9;
            this.stock.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock: ";
            // 
            // lsv_Prod
            // 
            this.lsv_Prod.HideSelection = false;
            this.lsv_Prod.Location = new System.Drawing.Point(238, 97);
            this.lsv_Prod.Name = "lsv_Prod";
            this.lsv_Prod.Size = new System.Drawing.Size(365, 408);
            this.lsv_Prod.TabIndex = 6;
            this.lsv_Prod.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(320, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Products(Stock)";
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsv_Prod);
            this.Controls.Add(this.label1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(856, 595);
            this.Load += new System.EventHandler(this.UC_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsv_Prod;
        private System.Windows.Forms.Label label1;
    }
}
