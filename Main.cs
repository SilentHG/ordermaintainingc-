using System;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
namespace VPPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RowIndex = 0;
        Sales Sales_Open = new Sales();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Product_Load(object sender, MouseEventArgs e)
        {
            Button ProductButton = sender as Button;
            DataAccess DA = new DataAccess();
            String Product_Name = ProductButton.Text;
            Details ProductDetails = DA.RetreiveProductDetails(ProductButton.Text);

            if (CheckProductAlreadyAdded(ProductButton.Text))
            {
                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity = Convert.ToInt32(TempOrder.Rows[RowIndex].Cells["Grid_Quantity"].Value);
                decimal Price = Convert.ToInt32(TempOrder.Rows[RowIndex].Cells["Grid_Price"].Value);

                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                TempOrder.Rows[RowIndex].Cells["Grid_Quantity"].Value = Quantity;
                TempOrder.Rows[RowIndex].Cells["Grid_Total"].Value = TotalPrice;

                TotalBillBox.Text = CalculateTotalBill(TempOrder).ToString();
            }
            else
            {
                TempOrder.Rows.Add(1, ProductDetails.ID, ProductDetails.Name, ProductDetails.Price, ProductDetails.Price * 1);

                TotalBillBox.Text = CalculateTotalBill(TempOrder).ToString();
            }


        }
        public bool CheckProductAlreadyAdded(String Product_Name)
        {
            foreach (DataGridViewRow Row in TempOrder.Rows)
            {
                if (Convert.ToString(Row.Cells["Grid_Name"].Value) == Product_Name)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotalBill(DataGridView TempOrder)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in TempOrder.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["Grid_Total"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        private void Load_Data(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow Row in TempOrder.Rows)
            {
                String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert_gridview_all";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                DateTime time = DateTime.Now;
                string ProductName = Convert.ToString(Row.Cells["Grid_Name"].Value);
                decimal ProductPrice = Convert.ToDecimal(Row.Cells["Grid_Price"].Value);
                int ProductID = Convert.ToInt32(Row.Cells["Grid_ID"].Value);
                int Quantity = Convert.ToInt32(Row.Cells["Grid_Quantity"].Value);
                int ProductTotal = Convert.ToInt32(Row.Cells["Grid_Total"].Value);
                cmd.Parameters.AddWithValue("@id",ProductID);
                cmd.Parameters.AddWithValue("@name", ProductName);
                cmd.Parameters.AddWithValue("@price",ProductPrice);
                cmd.Parameters.AddWithValue("@sale_time", time);
                cmd.Parameters.AddWithValue("@quan", Quantity);
                cmd.Parameters.AddWithValue("@total", ProductTotal);
                cmd.ExecuteNonQuery();
                con.Close();
                


                
            }
            MessageBox.Show("Data Loaded");
            TempOrder.Rows.Clear();
        }

       


        private void Main_Menu(object sender, EventArgs e)
        {

        }

        private void All_Sales(object sender, EventArgs e)
        {

            this.Hide();
            
            Sales_Open.ShowDialog();
            Sales_Open.StartPosition = FormStartPosition.CenterScreen;
            this.Close();

        }

        private void Query_Form(object sender, EventArgs e)
        {
            this.Hide();
            Queries Query = new Queries();

            Query.ShowDialog();
            Query.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Update_Product(object sender, EventArgs e)
        {
            this.Hide();
            Product_Update product_Update = new Product_Update();

            product_Update.ShowDialog();
            product_Update.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            TempOrder.Rows.Clear();
        }

        private void Delete_Sale_Load(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Sale Delete = new Delete_Sale();

            Delete.ShowDialog();
            Delete.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
