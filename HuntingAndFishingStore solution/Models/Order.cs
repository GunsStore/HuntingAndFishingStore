﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public Order()
        {
            IsDeliveried = false;
        }

        [Key]
        public int Id { get; set; }

        public DateTime OrderDate
        {
            get { return OrderDate; }
            set { OrderDate = DateTime.Now;}
        }

        public DateTime DeliveryDate
        {
            get { return DeliveryDate; }
            set { DeliveryDate = OrderDate.AddDays(7); }
        }

        public bool IsDeliveried { get; set; }

        public decimal PriceOfAllProducts { get; set; }

        public int BasketId { get; set; }

        public virtual Basket Basket{ get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int PaymentId { get; set; }

        public virtual Payment Payment{ get; set; }
    }
}