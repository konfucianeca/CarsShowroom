using System.ComponentModel.DataAnnotations;
using static CarsShowroom.Core.Constants.MessageConstants;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Core.Models.Customer
{
    public class CustomerFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CustomerNameMaxLenght,
            MinimumLength = CustomerNameMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CustomerPhoneMaxLenght,
            ErrorMessage = StringMaxLengthMessage)]
        public string PhoneNumber { get; set; } = string.Empty;


        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CustomerAddresslMaxLenght,
            ErrorMessage = StringMaxLengthMessage)]
        public string Address { get; set; } = string.Empty;
    }
}
