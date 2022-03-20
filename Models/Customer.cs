using System.ComponentModel.DataAnnotations.Schema;

namespace Restratant
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }


        [ForeignKey("Cart")]

        public int CartId { get; set; }

        public virtual Cart Cart { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
