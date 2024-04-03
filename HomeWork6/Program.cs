//First task
using HomeWork6;

var iphone = new Phone();
iphone.Number = 12345;
iphone.Model = "iphone";
iphone.Weight = 13;

iphone.Print();
iphone.ReciveCall("Oleg");
int phoneNumber1 = iphone.GetNumber();
iphone.ReciveCall("Oleg", 243556);
iphone.SendMessage();

Console.WriteLine(string.Format("Phone number: {0}", phoneNumber1));

Console.WriteLine();
//
var samsung = new Phone(65894, "samsung", 14);

samsung.Print();
samsung.ReciveCall("Ivan");
int phoneNumber2 = samsung.GetNumber();

Console.WriteLine(string.Format("Phone number: {0}", phoneNumber2));


Console.WriteLine();
//
var nokia = new Phone(57879, "nokia");
nokia.Weight = 15;

nokia.Print();
nokia.ReciveCall("Vasia");
int phoneNumber3 = nokia.GetNumber();

Console.WriteLine(string.Format("Phone number: {0}", phoneNumber3));

nokia.SendMessage(12323, 45664, 4568746);



