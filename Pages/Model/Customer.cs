using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Customer{
    public class CustomerInfo
    {
        [DisplayName("Your Name is:")]
        public string? Name{set;get;}
        [DisplayName("Your year of birth is:")]
        public int? BornYear{set;get;}
        [DisplayName("Your address is:")]
        public string? Address{set;get;}
        [DisplayName("Your email is:")]
        public string? Email{set;get;}
        [DisplayName("Your phone number is:")]
        public string? PhoneNum{set;get;}
    }
}