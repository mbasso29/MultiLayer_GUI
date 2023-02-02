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
    public partial class GUIForm : Form
    {
        private string connectString;
        public GUIForm(string connectionString)
        {
            connectString = connectionString;
            businessObject = new BusinessLogic(connectString);
            InitializeComponent();
        }
        
        private BusinessLogic businessObject;
        
        private void GUIForm_Load(object sender, EventArgs e)
        {


            EmpBtn.Visible = businessObject.getEmpAccess();
            OrdersBtn.Visible = businessObject.getOrdersAccess();
            custBtn.Visible = businessObject.getCustomerAccess();

        }

        private void EmpBtn_CheckedChanged(object sender, EventArgs e)
        {
            var dataObject = businessObject.getEmpInfoFromDatabase();
            recordsNoBox.Text = dataObject.countOfRecords.ToString();
            recListView.Items.Clear();

            foreach (var name in dataObject.listOfRecords)
            {
                recListView.Items.Add(new ListViewItem(name));
            }
        }

        private void OrdersBtn_CheckedChanged(object sender, EventArgs e)
        {
            var dataObject = businessObject.getOrderInfoFromDatabase();
            recordsNoBox.Text = dataObject.countOfRecords.ToString();
            recListView.Items.Clear();

            foreach (var name in dataObject.listOfRecords)
            {
                recListView.Items.Add(new ListViewItem(name));
            }
        }

        private void custBtn_CheckedChanged(object sender, EventArgs e)
        {
            var dataObject = businessObject.getCustInfoFromDatabase();
            recordsNoBox.Text = dataObject.countOfRecords.ToString();
            recListView.Items.Clear();

            foreach (var name in dataObject.listOfRecords)
            {
                recListView.Items.Add(new ListViewItem(name));
            }
        }
    }
}
