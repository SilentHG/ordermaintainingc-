using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VPPROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Perform(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            String Username = Convert.ToString(Username_textbox.Text);
            String Password = Convert.ToString(Password_textbox.Text);
            bool Confirm = dataAccess.Confirm_Login(Username,Password);
            if(Confirm == true)

            {
                this.Hide();
                Form1 Main = new Form1();
                Main.ShowDialog();
                Main.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Information");
            }


        }
    }
}
