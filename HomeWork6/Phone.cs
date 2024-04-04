
namespace HomeWork6
{
    internal class Phone
    {
        public int Number { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public void Print()
        {
            Console.WriteLine($"Phone number: {Number} Model: {Model} Weight: {Weight}");
        }

        public void ReciveCall(string name)
        {
            Console.WriteLine($"Calls: {name}");
        }

        public void ReciveCall(string name, int number)
        {
            Console.WriteLine($"Calls {name}, number {number}");
        }

        public int GetNumber()
        {
            return Number;
        }

        public void SendMessage(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("There are no subscribers for SMS");
               
            }

            for( var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Sending message to number: {numbers[i]}");
            }
        }

        public Phone(int number, string model, int weight) : this ( number, model)
        {
            Number = number;
            Model = model;  
            Weight = weight;
        }

        public Phone(int number, string model)
        {
            Number = number;
            Model = model;
        }

        public Phone()
        {
         
        }



    }
}

/*Класс Phone.
Создайте класс Phone, который содержит переменные number, model и weight.

Создайте три экземпляра этого класса.

Выведите на консоль значения их переменных.

Добавить в класс Phone методы: receiveCall, имеет один параметр – имя
звонящего. Выводит на консоль сообщение “Звонит {name}”.

getNumber – возвращает номер телефона. 

Вызвать эти методы для каждого из объектов.

Добавить конструктор в класс Phone, который принимает на вход три параметра
для инициализации переменных класса - number, model и weight.

Добавить конструктор, который принимает на вход два параметра для
инициализации переменных класса - number, model.

Добавить конструктор без параметров.

Вызвать из конструктора с тремя параметрами конструктор с двумя.

Добавьте перегруженный метод receiveCall, который принимает два параметра - имя
звонящего и номер телефона звонящего. Вызвать этот метод.

Создать метод sendMessage с аргументами переменной длины. 
Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение.
Метод выводит на консоль номера этих телефонов.*/