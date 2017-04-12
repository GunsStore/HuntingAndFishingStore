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
            PersonalNumber = new char[10];    
            IdentityCardNumber = new char[9];
            PostCode = new char[4];
            Orders = new HashSet<Order>();
            Baskets = new HashSet<Basket>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5),MaxLength(25)]
        public string Username{ get; set; }

        [Required]
        [MinLength(5), MaxLength(25)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [Column(TypeName = "char(4)")]
        public char[] PostCode{ get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public char[] PersonalNumber { get; set; }

        [Required]
        [Column(TypeName = "char(9)")]
        public char[] IdentityCardNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual  ICollection<Basket> Baskets { get; set; }
    }
}
