﻿namespace Models.Dtos
{
    using System.Web;

    public class RoundDTO
    {
        public HttpPostedFileBase Image { get; set; }

        public double Caliber { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
