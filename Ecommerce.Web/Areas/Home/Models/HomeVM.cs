namespace Ecommerce.Web.Areas.Home.Models
{
    public class HomeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string Img { get; set; }

        public string Category { get; set; }
        public string CategoryId { get; set; }
    }
}
