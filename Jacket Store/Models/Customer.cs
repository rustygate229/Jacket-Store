namespace Jacket_Store.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public Address Home { get; set; }
    }
}
