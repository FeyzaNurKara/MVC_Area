﻿using System;
using System.Collections.Generic;

namespace MVC_Area.Models.Northwind;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
