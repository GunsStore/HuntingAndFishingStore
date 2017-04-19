namespace Models.Dtos
{
    using System.Web;

    public class FlashlightDTO
    {
        public HttpPostedFileBase Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string BatteryType { get; set; }

        public int Quantity { get; set; }
    }
}
