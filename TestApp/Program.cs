using System;

namespace TestApp
{
    public enum Name
    {
        Mahdyar
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var s = Enum.GetValues(typeof(RoleName));

            //foreach (var item in Enum.GetValues(typeof(RoleName)))
            //{
            //    Console.WriteLine(item.ToString());
            //}

            var s = DateTime.Now.Date;
            var n = s.AddDays(1);

            ulong[] sds;
            sds = new ulong[20];

            sds[1] = 142;

            Console.WriteLine(n);

            Console.ReadKey();
        }
    }

    public enum RoleName : byte
    {
        Admin,
        Operator,
        User = 100
    }



}
