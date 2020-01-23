namespace VPPROJECT
{
    partial class Sales
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.All_Records = new System.Windows.Forms.DataGridView();
            this.Grid_Sale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Sale_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_Records)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.updateProductToolStripMenuItem,
            this.deleteSalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.viewSalesToolStripMenuItem.Text = "Order Screen";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.Main_Menu_Load);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestSellerToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // bestSellerToolStripMenuItem
            // 
            this.bestSellerToolStripMenuItem.Name = "bestSellerToolStripMenuItem";
            this.bestSellerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bestSellerToolStripMenuItem.Text = "All Queries ";
            this.bestSellerToolStripMenuItem.Click += new System.EventHandler(this.Query_Load);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.Update_Product);
            // 
            // deleteSalesToolStripMenuItem
            // 
            this.deleteSalesToolStripMenuItem.Name = "deleteSalesToolStripMenuItem";
            this.deleteSalesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deleteSalesToolStripMenuItem.Text = "Delete Sales";
            this.deleteSalesToolStripMenuItem.Click += new System.EventHandler(this.Delete_Sales);
            // 
            // All_Records
            // 
            this.All_Records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_Records.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_Sale_ID,
            this.Grid_Sale_Time,
            this.Grid_ID,
            this.Grid_Name,
            this.Grid_Price,
            this.Grid_Quantity,
            this.Grid_Total});
            this.All_Records.Location = new System.Drawing.Point(22, 37);
            this.All_Records.Name = "All_Records";
            this.All_Records.Size = new System.Drawing.Size(936, 448);
            this.All_Records.TabIndex = 8;
            this.All_Records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.All_Records_CellContentClick);
            // 
            // Grid_Sale_ID
            // 
            this.Grid_Sale_ID.HeaderText = "Sale_ID";
            this.Grid_Sale_ID.Name = "Grid_Sale_ID";
            // 
            // Grid_Sale_Time
            // 
            this.Grid_Sale_Time.HeaderText = "Sale_Time";
            this.Grid_Sale_Time.Name = "Grid_Sale_Time";
            // 
            // Grid_ID
            // 
            this.Grid_ID.HeaderText = "Product_ID";
            this.Grid_ID.Name = "Grid_ID";
            // 
            // Grid_Name
            // 
            this.Grid_Name.HeaderText = "Product_Name";
            this.Grid_Name.Name = "Grid_Name";
            // 
            // Grid_Price
            // 
            this.Grid_Price.HeaderText = "Product_Price";
            this.Grid_Price.Name = "Grid_Price";
            // 
            // Grid_Quantity
            // 
            this.Grid_Quantity.HeaderText = "Quantity";
            this.Grid_Quantity.Name = "Grid_Quantity";
            // 
            // Grid_Total
            // 
            this.Grid_Total.HeaderText = "Total";
            this.Grid_Total.Name = "Grid_Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(988, 527);
            this.Controls.Add(this.All_Records);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_Records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerToolStripMenuItem;
        private System.Windows.Forms.DataGridView All_Records;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Sale_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Sale_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Total;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesToolStripMenuItem;
    }
}