﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace madmax.Models
{
    public class PaymentsModel
    {
        public string TenantName { get; set; } // Name of the tenant
        public string ApartmentNumber { get; set; } // Apartment/Flat number
        public decimal RentAmount { get; set; } // Rent amount
        public decimal MaintenanceCharges { get; set; } // Maintenance charges
        public decimal GasCharges { get; set; } // Gas charges
        public decimal WaterCharges { get; set; } // Water charges
        public decimal ElectricityCharges { get; set; } // Electricity (current) charges

        // Total payable amount is the sum of all charges
        public decimal TotalAmount { get; set; }
    }
}