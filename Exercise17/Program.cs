using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17

    //Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
    //Создать  несколько экземпляров класса, параметризированного различными типам.
    //Заполнить его поля и вывести информацию об экземпляре класса на печать.
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите числовой номер счета");
                int numInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца");
                string name = Console.ReadLine();
                Console.WriteLine("Введите баланс");
                int balance = Convert.ToInt32(Console.ReadLine());

                BankAccount<int> bankAccount1 = new BankAccount<int>(numInt, name, balance);

                Console.WriteLine("Введите строковый номер счета");
                string numString = Console.ReadLine();
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();
                Console.WriteLine("Введите баланс");
                balance = Convert.ToInt32(Console.ReadLine());

                BankAccount<string> bankAccount2 = new BankAccount<string>(numString, name, balance);

                Console.WriteLine(bankAccount1.GetInfo());
                Console.WriteLine(bankAccount2.GetInfo());
                Console.ReadKey();
            }
        }
    }