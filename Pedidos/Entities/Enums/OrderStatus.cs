﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pedidos.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}