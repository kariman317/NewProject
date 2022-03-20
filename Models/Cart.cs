using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restratant.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Counter { get; set; }


        //fk cus
        //collection of meal 

        //Question ??????????
        //[ForeignKey("Meal")]
        //public int MealId { get; set; }
        //public virtual Meal Meal { get; set; }
        //[ForeignKey("Customer")]
        //public int CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }

    }
}
