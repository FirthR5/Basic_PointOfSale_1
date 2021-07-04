
namespace PointOfSale_1
{
    partial class ReportForProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lsv_Prod = new System.Windows.Forms.ListView();
            this.brn_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products(Stock)";
            // 
            // lsv_Prod
            // 
            this.lsv_Prod.HideSelection = false;
            this.lsv_Prod.Location = new System.Drawing.Point(42, 107);
            this.lsv_Prod.Name = "lsv_Prod";
            this.lsv_Prod.Size = new System.Drawing.Size(344, 247);
            this.lsv_Prod.TabIndex = 1;
            this.lsv_Prod.UseCompatibleStateImageBehavior = false;
            // 
            // brn_refresh
            // 
            this.brn_refresh.Location = new System.Drawing.Point(243, 400);
            this.brn_refresh.Name = "brn_refresh";
            this.brn_refresh.Size = new System.Drawing.Size(75, 23);
            this.brn_refresh.TabIndex = 2;
            this.brn_refresh.Text = "Refresh";
            this.brn_refresh.UseVisualStyleBackColor = true;
            this.brn_refresh.Click += new System.EventHandler(this.brn_refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock: ";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(50, 428);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(13, 13);
            this.stock.TabIndex = 4;
            this.stock.Text = "0";
            // 
            // ReportForProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brn_refresh);
            this.Controls.Add(this.lsv_Prod);
            this.Controls.Add(this.label1);
            this.Name = "ReportForProducts";
            this.Text = "ReportForProducts";
            this.Load += new System.EventHandler(this.ReportForProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsv_Prod;
        private System.Windows.Forms.Button brn_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stock;
    }
}