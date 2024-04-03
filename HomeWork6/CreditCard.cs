
namespace HomeWork6
{
    public class CreditCard
    {
        private int _accountNumber;
        private double _currentAmount;

        public void MakeDeposit(double summ)
        {
            if (summ <= 0)
            {
                Console.WriteLine("Icorrect amount. Try again.\n");
            }

            else
            {
                _currentAmount += summ;
                Console.WriteLine($"The balance has been replenished\n");
            }
        }

        public void SpendMoney(double summ)
        {
            double chek = _currentAmount - summ;

            if( chek < 0 )
            {
                Console.WriteLine("Insufficient funds\n");
            }

            else
            {
                _currentAmount -= summ;
                Console.WriteLine($"The money has been transferred\n");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Account number: {_accountNumber}\nCurent amount: {_currentAmount}\n");
        }
        public CreditCard(int accountNumber, double currentAmount)
        {
            _accountNumber = accountNumber;
            _currentAmount = currentAmount;
        }
    }

}

/*Создать класс CreditCard c полями номер счета, текущая сумма на счету.
+Добавьте метод, который позволяет начислять сумму на кредитную
карточку.
Добавьте метод, который позволяет снимать с карточки некоторую
сумму.
Добавьте метод, который выводит текущую информацию о карточке.

Напишите программу, которая создает три объекта класса CreditCard у
которых заданы номер счета и начальная сумма

Тестовый сценарий для проверки:

Положите деньги на первые две карточки и снимите с третьей.

Выведите на экран текущее состояние всех трех карточек.*/