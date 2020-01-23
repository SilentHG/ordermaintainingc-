namespace VPPROJECT
{
    partial class Product_Update
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
            this.Product_Select_Combobox = new System.Windows.Forms.ComboBox();
            this.Product_Price_NU = new System.Windows.Forms.NumericUpDown();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Price_NU)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product_Name";
            // 
            // Product_Select_Combobox
            // 
            this.Product_Select_Combobox.FormattingEnabled = true;
            this.Product_Select_Combobox.Location = new System.Drawing.Point(224, 54);
            this.Product_Select_Combobox.Name = "Product_Select_Combobox";
            this.Product_Select_Combobox.Size = new System.Drawing.Size(121, 21);
            this.Product_Select_Combobox.TabIndex = 2;
            // 
            // Product_Price_NU
            // 
            this.Product_Price_NU.Location = new System.Drawing.Point(225, 104);
            this.Product_Price_NU.Name = "Product_Price_NU";
            this.Product_Price_NU.Size = new System.Drawing.Size(120, 20);
            this.Product_Price_NU.TabIndex = 3;
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Button.Location = new System.Drawing.Point(130, 141);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(93, 31);
            this.Submit_Button.TabIndex = 4;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Load_New_Price);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change The Price of Existing Products";
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
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 7;
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
            // 
            // deleteSalesToolStripMenuItem
            // 
            this.deleteSalesToolStripMenuItem.Name = "deleteSalesToolStripMenuItem";
            this.deleteSalesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deleteSalesToolStripMenuItem.Text = "Delete Sales";
            this.deleteSalesToolStripMenuItem.Click += new System.EventHandler(this.Delete_Sales);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "New_Price";
            // 
            // Product_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(403, 195);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Product_Price_NU);
            this.Controls.Add(this.Product_Select_Combobox);
            this.Controls.Add(this.label1);
            this.Name = "Product_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Update";
            this.Load += new System.EventHandler(this.Product_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Product_Price_NU)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Product_Select_Combobox;
        private System.Windows.Forms.NumericUpDown Product_Price_NU;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}