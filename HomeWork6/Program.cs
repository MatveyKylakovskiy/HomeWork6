//First task
/*using HomeWork6;

var iphone = new Phone()
{
    Number = 12345,
    Model = "iphone",
    Weight = 13
};

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
var nokia = new Phone(57879, "nokia")
{
    Weight = 15
};


nokia.Print();
nokia.ReciveCall("Vasia");
int phoneNumber3 = nokia.GetNumber();

Console.WriteLine(string.Format("Phone number: {0}", phoneNumber3));

nokia.SendMessage(12323, 45664, 4568746);
*/

//Second task

/*using HomeWork6;

var myBank = new CreditCard(030420245, 0);
var visaBank = new CreditCard(020420246, 100);
var masterBank = new CreditCard(01022023, 500.1);

myBank.GetInfo();
visaBank.GetInfo();
masterBank.GetInfo();

Console.WriteLine("\nAccount transactions\n");

myBank.MakeDeposit(15);
visaBank.MakeDeposit(-15);
masterBank.SpendMoney(2);

myBank.GetInfo();
visaBank.GetInfo();
masterBank.GetInfo();
*/

//Third task
using HomeWork6;
using static HomeWork6.ATM;

var myATM = new ATM();

myATM.PutMoney(1, Bills.bill20);
myATM.PutMoney(2, Bills.bill50);
myATM.PutMoney(2, Bills.bill100);
myATM.PutMoney(1, Bills.bill20);

myATM.GetInfo(Bills.bill20);
myATM.GetInfo(Bills.bill50);
myATM.GetInfo(Bills.bill100);


myATM.GetMoney(90);

myATM.GetInfo(Bills.bill20);
myATM.GetInfo(Bills.bill50);

var bankATM = new ATM(20, 30, 50);
bankATM.GetInfo(Bills.bill20);
bankATM.GetInfo(Bills.bill50);
bankATM.GetInfo(Bills.bill100);

bankATM.GetMoney(170);
bankATM.GetMoney(500);
bankATM.GetMoney(1);