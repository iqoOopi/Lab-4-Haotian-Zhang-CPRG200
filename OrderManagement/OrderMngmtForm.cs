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
        List<OrderDetails> RelatedOrderDetails;
        Orders selectedOrder;
        int selectedRowNumber;
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
            if(ordersDataGridView.SelectedRows.Count>0)
            {
                RelatedOrderDetails = new List<OrderDetails>();
                selectedRowNumber = ordersDataGridView.SelectedRows[0].Index;
                selectedOrder = Orders[selectedRowNumber];
                int orderID = selectedOrder.OrderID;
                foreach (OrderDetails details in OrderDetails)
                {
                    if (details.OrderID == orderID)
                    {
                        RelatedOrderDetails.Add(details);
                    }
                }

            }
            orderDetailsDataGridView.DataSource = RelatedOrderDetails;
            decimal subTotal=0m;
            foreach (DataGridViewRow row in orderDetailsDataGridView.Rows)
            {
                decimal unitPrice = (decimal)row.Cells["dgUnitPrice"].Value;
                decimal discount = (decimal)row.Cells["dgDiscount"].Value;
                decimal quantity = Convert.ToDecimal(row.Cells["dgQuantity"].Value);
                decimal lineTotal = unitPrice * (1 - discount) * quantity;
                row.Cells["dgTotal"].Value = lineTotal;
                subTotal += lineTotal;
            }
            subTotal=Math.Round(subTotal, 2);
            txtBoxSubtotal.Text = "$" + subTotal.ToString();

            btnEditShippedDate.Enabled = true;
            pnlShippedDate.Visible = false;
            mtxtBoxShippedDate.Text = "";
        }

        private void btnEditShippedDate_Click(object sender, EventArgs e)
        {
            pnlShippedDate.Visible = true;
            mtxtBoxShippedDate.Select();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            DateTime newShippedDate;
            if (!DateTime.TryParse(mtxtBoxShippedDate.Text, out newShippedDate))
            {
               
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
            Orders[selectedRowNumber] = selectedOrder;
            ordersDataGridView.Refresh();

            //commit to DB
            if (GenericDB.GenericUpdate<Orders>("Orders", oldSelectedOrder, selectedOrder)!=1){
                MessageBox.Show("Update Failed");
            }



        }
    }
}
