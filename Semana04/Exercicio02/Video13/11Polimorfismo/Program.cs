using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tax t = new Trainee();
            t.AlimentationVoucher(800);
            t.TransportVoucher(800);
            Console.WriteLine("=================================================");

            Tax m = new Manager();
            m.AlimentationVoucher(5000);
            m.TransportVoucher(5000);
            Console.WriteLine("=================================================");

            Tax a = new Attendant();
            a.AlimentationVoucher(2500);
            a.TransportVoucher(2500);
            Console.WriteLine("=================================================");
        }
    }
}