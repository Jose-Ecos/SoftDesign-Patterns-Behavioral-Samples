namespace Null_object.Domain
{
    public class Address
    {

        public static readonly Address NULL_ADDRESS = new Address("NOT ADDRESS");

        public string FullAddress { get; set; }

        public Address(string FullAddress)
        {
            this.FullAddress = FullAddress;
        }

        public Address()
        {
        }
    }
}
