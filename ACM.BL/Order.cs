﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int? OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            if (CustomerId == null) isValid = false;
            if (OrderId == null) isValid = false;

            return isValid;
        }

    }
}
