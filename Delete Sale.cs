using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VPPROJECT
{
    public partial class Delete_Sale : Form
    {
        public Delete_Sale()
        {
            InitializeComponent();
        }

        private void Delete_Perform(object sender, EventArgs e)
        {
            if (Grid_Delete.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.Grid_Delete.SelectedRows)
                {
                    String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
                    int id = Convert.ToInt32(Grid_Delete.SelectedRows[0].Cells[0].Value);
                    SqlConnection con = new SqlConnection(ConnectionString);
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "delete_sales";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sale_id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Grid_Delete.Rows.Remove(Grid_Delete.SelectedRows[0]);
                    MessageBox.Show("Row Deleted");



                }
            }
            else
            {
                MessageBox.Show("Please Select A Row");
            }
        }



            
        

        private void Delete_Sale_Load(object sender, EventArgs e)
        {
            String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
            Details ProductDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Sale_ID,Sale_Time,Product_ID,Product_Name,Product_Price,Product_Quantity,Product_Total FROM [Project].[dbo].[Sales] order by Sale_ID;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductDetails.SaleID = reader.GetInt32(0);
                        ProductDetails.SaleTime = reader.GetDateTime(1);
                        ProductDetails.ID = reader.GetInt32(2);
                        ProductDetails.Name = reader.GetString(3);
                        ProductDetails.Price = reader.GetInt32(4);
                        ProductDetails.Quantity = reader.GetInt32(5);
                        ProductDetails.Total = reader.GetInt32(6);
                        Grid_Delete.Rows.Add(ProductDetails.SaleID, ProductDetails.SaleTime, ProductDetails.ID, ProductDetails.Name, ProductDetails.Price, ProductDetails.Quantity, ProductDetails.Total);


                    }
                }
                reader.Close();


            }
        }

        private void Main_Menu(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Main = new Form1();
            Main.ShowDialog();
            Main.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            this.Hide();
            Sales Sales_Open = new Sales();
            Sales_Open.ShowDialog();
            Sales_Open.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            this.Hide();
            Queries Query = new Queries();

            Query.ShowDialog();
            Query.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Update_Product_load(object sender, EventArgs e)
        {
            this.Hide();
            Product_Update product_Update = new Product_Update();

            product_Update.ShowDialog();
            product_Update.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }
    }
}
