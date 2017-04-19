namespace Models.Dtos
{
    using System.Web;

    public class HolsterDTO
    {
        public HttpPostedFileBase Image { get; set; }

        public virtual Category Category { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
