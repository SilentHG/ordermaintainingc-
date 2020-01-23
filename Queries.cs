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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void Rank_Button_Click(object sender, EventArgs e)
        {
            String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
            Details ProductDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Product_Name,Count(Product_Name) FROM [Project].[dbo].[Sales] group by Product_Name order by Count(Product_Name) desc;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductDetails.Name = reader.GetString(0);
                        int Count = reader.GetInt32(1);
                        
                        Rank_Grid.Rows.Add(ProductDetails.Name,Count);


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

        private void Sales_Load(object sender, EventArgs e)
        {
            this.Hide();
            Sales Sales_Open = new Sales();
            Sales_Open.ShowDialog();
            Sales_Open.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Current_Month_Button_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Update_Product(object sender, EventArgs e)
        {
            this.Hide();
            Product_Update product_Update = new Product_Update();

            product_Update.ShowDialog();
            product_Update.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Delete_Sales(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Sale Delete = new Delete_Sale();

            Delete.ShowDialog();
            Delete.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }
    }
}
