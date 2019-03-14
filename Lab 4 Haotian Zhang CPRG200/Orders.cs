using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class Orders
    {
        public Orders(int orderID, string customerID, DateTime? orderDate, DateTime? requiredDate, DateTime? shippedDate)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
        }

        public Orders() { }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
