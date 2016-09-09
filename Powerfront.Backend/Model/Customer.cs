﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerfront.Backend.Model
{
    public class Customer : ICustomer
    {
        public string CustomerId { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
