using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Zadanie17
    {
        static void Main(string[] args)
        {
            Account<object> account1 = new Account<object>(000, "Mister1");
            account1.AccountNumber = 005;

            Account<object> account2 = new Account<object>(000, "Mister1");
            account1.AccountNumber = 006;

            string neoowner = account1<006>.GetSaldo();

            Console.WriteLine("{0}", account1);
            Console.WriteLine("{0}", account2);
        }
    }
    public class Account <T>
    {
    public T AccountNumber { get; set; }
    int AccountSaldo { get; set; }
    object AccountOwner { get; set; }

    public Account(int saldo, object owner)
        {
            Account<T>.GetSaldo();
            this.AccountSaldo = saldo;
            this.AccountOwner = owner;
        }
    static public int GetSaldo()
        {
            int saldo = 0;
            Console.WriteLine("Введите сальдо счета:");
            saldo = Convert.ToInt32(Console.ReadLine());
            return saldo;
        }
    public static string GetOwner()
        {
            Console.WriteLine("Введите ФИО владельца счета:");
            string owner = Convert.ToString(Console.ReadLine());
            return owner;
        }


    }
}
