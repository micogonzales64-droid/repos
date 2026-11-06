using System;

public class Class1
{
    class Program
    {
        static void Showinfo()
        {
            bool balance = 2 == 2;
            Console.WriteLine("Balance is " + balance);

            bool voter = 8 < 18;
            Console.WriteLine("Are you a voter: " + voter);

            int sure = 1;
            Console.WriteLine("Are you sure? " + (sure != 0));
        }
    }
}