﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
  public class Order
    {
        public int  Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public double TotalPrice { get; set; }
        public bool IsShipped { get; set; }

        public Shipment Shipment { get; set; }


    }
}
