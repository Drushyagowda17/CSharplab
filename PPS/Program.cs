namespace PPS
{
    using System;

    namespace Store
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Payment creditCardPayment = new CreditCardPayment(1500, DateTime.Now, "564987654", "rahul");
                creditCardPayment.ProcessPayment();

                Payment upiPayment = new UPIPayment(400, DateTime.Now, "rahul99.upi", "State  Bank");
                upiPayment.ProcessPayment();
            }
        }
    }

}
