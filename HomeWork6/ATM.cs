

using System.ComponentModel.Design;

namespace HomeWork6

{
    internal class ATM
    {
        public enum Bills
        {
            bill20,
            bill50,
            bill100
        }

        public const int _nominalValue20 = 20;
        public const int _nominalValue50 = 50;
        public const int _nominalValue100 = 100;

        private int _counter20;
        private int _counter50;
        private int _counter100;


        public void PutMoney(int quantity, Bills bill)
        {
            switch (bill)
            {
                case Bills.bill20:
                    _counter20 += quantity;
                    break;

                case Bills.bill50:
                    _counter50 += quantity;
                    break;

                case Bills.bill100:
                    _counter100 += quantity;
                    break;

            }
        }

        public void GetInfo(Bills bill)
        {
            switch (bill)
            {
                case Bills.bill20:
                    Console.WriteLine($"20 bills sums:{_counter20 * _nominalValue20} qantiti {_counter20}");
                    break;

                case Bills.bill50:
                    Console.WriteLine($"50 bills sums: {_counter50 * _nominalValue50} qantiti {_counter50}");
                    break;

                case Bills.bill100:
                    Console.WriteLine($"100 bills sums: {_counter100 * _nominalValue100} qantiti {_counter100}");
                    break;

            }
        }

        public bool GetMoney(int summ)
        {


            if (summ % _nominalValue100 == 0)
            {

                return GetMoneyHelper(summ, _nominalValue100, ref _counter100);
            }

            if (summ % 50 == 0)
            {
                return GetMoneyHelper(summ, _nominalValue50, ref _counter50);
            }

            if (summ % 20 == 0 && (summ - 70) % 20 != 0)
            {
                return GetMoneyHelper(summ, _nominalValue20, ref _counter20);
            }

            if ((summ - 70) % 20 == 0)
            {
                return GetMoneyHelper(summ, _nominalValue20, _nominalValue50, ref _counter20, ref _counter50);
            }

            Console.WriteLine("Incorrect amount.\nTry again.");
            return false;
        }

        public bool GetMoneyHelper(int summ, int _nominalValue, ref int counter)
        {
            int quantity = summ / _nominalValue;
            if (quantity <= counter)
            {   
                counter -= quantity;
                Console.WriteLine(string.Format("{0} quantity {1}", _nominalValue, quantity));
                return true;
            }

            Console.WriteLine("Incorrect amount.\n Try again.");
            return false;
        }

        public bool GetMoneyHelper(int summ, int _nominalValue1, int _nominalValue2, ref int counter1, ref int counter2)
        {
            int quantity = (summ - _nominalValue1 - _nominalValue2) / _nominalValue1;

            if (quantity + 1 <= counter1 && counter2 >= 1)
            {   
                counter1 -= quantity+1;
                counter2--;

                Console.WriteLine(string.Format("{0} quantity {1} and {2} quantity {3}", _nominalValue1, quantity + 1, _nominalValue2, 1));
                return true;
            }

            Console.WriteLine("Incorrect amount.\n Try again.");
            return false;
        }

        public ATM()
        {

        }

        public ATM(int counter20, int counter50, int counter100)
        {
            _counter20 = counter20;
            _counter50 = counter50;
            _counter100 = counter100;
        }
    }    
}



/*Создать класс, описывающий банкомат.
Набор купюр, находящихся в банкомате, должен задаваться тремя
свойствами:
количеством купюр номиналом 20, 50 и 100.
Сделать метод для добавления денег в банкомат.
Сделать метод, снимающуий деньги, который принимает сумму денег,
а возвращает булевое значение - успешность выполнения операции.
При снятии денег метод должен распечатывать каким количеством
купюр какого номинала выдаётся сумма.
Создать конструктор с тремя параметрами - количеством купюр каждого
номинала.*/