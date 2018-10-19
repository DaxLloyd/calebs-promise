﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebsPromise.Models
{
    public interface IOrderRepository 
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
