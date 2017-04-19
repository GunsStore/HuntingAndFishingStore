namespace Models.Dtos
{
    using System.Web;

    public class KnifeDTO
    {
        public HttpPostedFileBase Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }
        public int Quantity { get; set; }
    }
}
