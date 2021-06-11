using enumeraçãoString.Entities;
using System;
using enumeraçãoString.Entities.Enums;

namespace enumeraçãoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Order orden = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(orden);



        }
    }
}
