using System.ComponentModel.DataAnnotations;

namespace HandsOnBlazorFormValidations.Models
{
    

    public class OrderModel
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        public string City { get; set; }
    }

    public class CustomerModel
    {
       
        public string Name { get; set; }
    }

    public class AddressModel
    {
       
        public string City { get; set; }
    }





}
