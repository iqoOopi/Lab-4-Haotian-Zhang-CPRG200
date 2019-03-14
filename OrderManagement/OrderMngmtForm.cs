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
        List<Orders> Orders;//list of all Orders
        List<OrderDetails> OrderDetails;//List of all orderDetails
        List<OrderDetails> RelatedOrderDetails;//List of all orderDetails related to the selected order
        Orders selectedOrder;//selected order
        //int selectedRowNumber;
        public OrderMngmtForm()
        {
            InitializeComponent();
        }

        private void OrderMngmt_Load(object sender, EventArgs e)
        {
            //load Data from DB
            LoadData();
            
        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(ordersDataGridView.SelectedRows.Count>0)//check are there any selection made
            {
                RelatedOrderDetails = new List<OrderDetails>();
                int selectedRowNumber = ordersDataGridView.SelectedRows[0].Index;//get index num for array
                selectedOrder = Orders[selectedRowNumber];
                int orderID = selectedOrder.OrderID;//get PK for search relevant in OrderDetails
                //Finding related Details
                foreach (OrderDetails details in OrderDetails)
                {
                    if (details.OrderID == orderID)
                    {
                        RelatedOrderDetails.Add(details);//add ralted details to list
                    }
                }

            }
            //bound relatedOrderDetails to DataGridView
            orderDetailsDataGridView.DataSource = RelatedOrderDetails;
            decimal subTotal=0m;
            //calculate lineTotal for each line,then add lineTotal to subTotal
            foreach (DataGridViewRow row in orderDetailsDataGridView.Rows)
            {
                decimal unitPrice = (decimal)row.Cells["dgUnitPrice"].Value;
                decimal discount = (decimal)row.Cells["dgDiscount"].Value;
                decimal quantity = Convert.ToDecimal(row.Cells["dgQuantity"].Value);
                decimal lineTotal = unitPrice * (1 - discount) * quantity;
                //display calculated lineTotal 
                row.Cells["dgTotal"].Value = lineTotal;
                subTotal += lineTotal;
            }
            subTotal=Math.Round(subTotal, 2);
            txtBoxSubtotal.Text = "$" + subTotal.ToString();

            //prepare the input area
            btnEditShippedDate.Enabled = true;
            pnlShippedDate.Visible = false;
            mtxtBoxShippedDate.Text = "";
        }

        private void btnEditShippedDate_Click(object sender, EventArgs e)
        {
            //show the input area
            pnlShippedDate.Visible = true;
            mtxtBoxShippedDate.Select();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            DateTime newShippedDate;//new DateTime about to update
            if (!DateTime.TryParse(mtxtBoxShippedDate.Text, out newShippedDate))
            {
               //not valid input
                MessageBox.Show("Invalid Input, please input MM/DD/YYYY");
                mtxtBoxShippedDate.Text = "";
                return;
            }
            
            DateTime? orderDate = selectedOrder.OrderDate;
            DateTime? requiredDate = selectedOrder.RequiredDate;
            if (orderDate!=null && newShippedDate<orderDate)
            {
                MessageBox.Show("Error! Shipped Date:"+newShippedDate.ToShortDateString()+" is ealier than OrderDate");
                mtxtBoxShippedDate.Text = "";
                return;
            }
            if (requiredDate!=null && newShippedDate > requiredDate)
            {
                MessageBox.Show("Error! Shipped Date:"+newShippedDate.ToShortDateString()+" is later than Required Date");
                mtxtBoxShippedDate.Text = "";
                return;
            }

            //good date
            //Orders oldSelectedOrder = selectedOrder; This is horrible wrong, reference type!
            Orders oldSelectedOrder = new Orders(selectedOrder.OrderID, selectedOrder.CustomerID, selectedOrder.OrderDate, selectedOrder.RequiredDate, selectedOrder.ShippedDate);
            selectedOrder.ShippedDate = newShippedDate;
            //Orders[selectedRowNumber] = selectedOrder;
            

            //commit to DB
            try
            {
                if (GenericDB.GenericUpdate<Orders>("Orders", oldSelectedOrder, selectedOrder) != 1)
                {
                    MessageBox.Show("Data changed while you are editing, Please refresh and try again!");
                    LoadData();
                }
                else
                {
                    LoadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void LoadData()
        {
            //get data from DB and bound it to GridView
            Orders = GenericDB.GenericRead<Orders>("Orders");
            OrderDetails = GenericDB.GenericRead<OrderDetails>("[Order Details]");
            ordersDataGridView.DataSource = Orders;
            ordersDataGridView.Refresh();
        }
    }
}
