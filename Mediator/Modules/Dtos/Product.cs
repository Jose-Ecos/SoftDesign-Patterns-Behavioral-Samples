namespace Mediator.Modules.Dtos
{
    public class Product
    {
        public string Name { get; set; }

        public Product(string Name)
        {
            this.Name = Name;
        }
    }
}
