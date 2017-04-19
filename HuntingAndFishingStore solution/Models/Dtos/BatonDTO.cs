
namespace Models.Dtos
{
    using System.Web;

    public class BatonDTO
    {
        public string Name { get; set; }

        public HttpPostedFileBase Image { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Weight { get; set; }
        public int Quantity { get; set; }
    }
}
