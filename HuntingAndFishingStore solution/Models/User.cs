using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Baskets = new HashSet<Basket>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5,ErrorMessage = "Username must be at least 5 symbols!"),MaxLength(25,ErrorMessage = "Username is up to 25 symbols long!")]
        public string Username{ get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MinLength(5,ErrorMessage = "Password must be at least 5 symbols!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostCode{ get; set; }
  
        public string PersonalNumber { get; set; }

        public string IdentityCardNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual  ICollection<Basket> Baskets { get; set; }
    }
}
