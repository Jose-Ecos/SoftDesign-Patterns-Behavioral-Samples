namespace Mediator.Modules.Dtos
{
    public class SaleOrder : Sale
    {
        public string Id { get; set; }

        public SaleOrder(string Id)
        {
            this.Id = Id;
        }
    }
}
