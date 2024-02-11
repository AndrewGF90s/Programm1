Console.WriteLine("Hello world");

int a1 = 3;

int b1 = 4;

int c1 = 5;

int d1 = 6;

double sum = (a1 * b1) / (c1 + d1);

Console.WriteLine(sum);

Console.WriteLine("ВВедите первое число");
int FirstNumber =int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int SecondNumber =int.Parse(Console.ReadLine());
int HightNumber = 0;
int SmallNumber = 0;
 
    if (FirstNumber > SecondNumber) {
    HightNumber = FirstNumber;
    SmallNumber = SecondNumber;
     Console.WriteLine("Большее число " + HightNumber);
    Console.WriteLine("Меньшее число " + SmallNumber);
    }
 
    else if (FirstNumber < SecondNumber) {
           
        HightNumber = SecondNumber;
        SmallNumber = FirstNumber;
        
    Console.WriteLine("Большее число " + HightNumber);
    Console.WriteLine("Меньшее число " + SmallNumber);
    }
    else {
        Console.WriteLine("Числа ровны");
        
    }


   