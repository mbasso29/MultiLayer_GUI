using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLayerGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server={SrvrTxtBox.Text};Database={databaseTxtBox.Text};User Id={userTxtBox.Text};Password={passTxtBox.Text};";
            if (string.IsNullOrEmpty(SrvrTxtBox.Text) || string.IsNullOrEmpty(databaseTxtBox.Text) || string.IsNullOrEmpty(userTxtBox.Text) || string.IsNullOrEmpty(passTxtBox.Text))
            {
                MessageBox.Show("All fields are required.");
            }
            else
            {
                var businessObject = new BusinessLogic(connectionString);
                if (businessObject.getLoginAccess())
                {
                    var GUIForm = new GUIForm(connectionString);
                    GUIForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
        }
    }
}
