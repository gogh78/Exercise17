using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class BankAccount<T>
    //Создать класс для моделирования счета в банке.
    //Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
    //Класс должен быть объявлен как обобщенный.
    //Универсальный параметр T должен определять тип номера счета.
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public BankAccount(T num, string name, int balance)
        {
            Num = num;
            Name = name;
            Balance = balance;
        }
        public string GetInfo()
        {
            return $"{Num}, {Name}, {Balance}";
        }
    }
}
