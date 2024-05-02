namespace Ecommerce_Project.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }


        public Products() { }
        public Products(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }
    }




}

