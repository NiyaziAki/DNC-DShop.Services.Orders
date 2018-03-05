﻿using System;
using System.Collections.Generic;
using static DShop.Services.Orders.Entities.Order;

namespace DShop.Services.Orders.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public long Number { get; set; }
        public IEnumerable<Guid> ProductIds { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
    }
}