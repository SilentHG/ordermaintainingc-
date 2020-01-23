namespace VPPROJECT
{
    partial class Delete_Sale
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
            this.Grid_Delete = new System.Windows.Forms.DataGridView();
            this.Grid_Sale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Delete)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Delete
            // 
            this.Grid_Delete.AllowUserToAddRows = false;
            this.Grid_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Delete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_Sale_ID,
            this.Grid_Time,
            this.Grid_ID,
            this.Grid_Name,
            this.Grid_Price,
            this.Grid_Quantity,
            this.Grid_Total});
            this.Grid_Delete.Location = new System.Drawing.Point(37, 43);
            this.Grid_Delete.Name = "Grid_Delete";
            this.Grid_Delete.Size = new System.Drawing.Size(744, 406);
            this.Grid_Delete.TabIndex = 0;
            // 
            // Grid_Sale_ID
            // 
            this.Grid_Sale_ID.HeaderText = "Sale_ID";
            this.Grid_Sale_ID.Name = "Grid_Sale_ID";
            // 
            // Grid_Time
            // 
            this.Grid_Time.HeaderText = "Sale_Time";
            this.Grid_Time.Name = "Grid_Time";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.updateProductToolStripMenuItem,
            this.deleteSalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.viewSalesToolStripMenuItem.Text = "Order Screen";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.Main_Menu);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestSellerToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.Sale_Load);
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
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.Update_Product_load);
            // 
            // deleteSalesToolStripMenuItem
            // 
            this.deleteSalesToolStripMenuItem.Name = "deleteSalesToolStripMenuItem";
            this.deleteSalesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deleteSalesToolStripMenuItem.Text = "Delete Sales";
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Red;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Location = new System.Drawing.Point(833, 154);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(91, 144);
            this.Delete_Button.TabIndex = 9;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Perform);
            // 
            // Delete_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1077, 549);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grid_Delete);
            this.Name = "Delete_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Sale";
            this.Load += new System.EventHandler(this.Delete_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Delete)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Sale_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Total;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesToolStripMenuItem;
    }
}