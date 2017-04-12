using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public PaymentType PaymentTypes { get; set; }

        [DataType(DataType.CreditCard)]
        public string CreditCardNumber
        {
            get { return CreditCardNumber; }
            set { CreditCardNumber = PaymentTypes.Equals(0) ? value : null; }
        }

        public enum PaymentType
        {
            CreditCard,
            CashOnDelivery
        }
    }
}