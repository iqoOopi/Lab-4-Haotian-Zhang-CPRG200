using EntityClass;
using DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class OrderMngmtForm : Form
    {
        List<Orders> Orders;
        List<OrderDetails> OrderDetails;
        public OrderMngmtForm()
        {
            InitializeComponent();
        }

        private void OrderMngmt_Load(object sender, EventArgs e)
        {
            Orders = GenericDB.GenericRead <Orders>("Orders");
            OrderDetails = GenericDB.GenericRead<OrderDetails>("[Order Details]");
            ordersDataGridView.DataSource = Orders;
            
        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //int orderID = (int)ordersDataGridView.SelectedRows[0].;
        }
    }
}
