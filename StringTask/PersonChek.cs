using System;


class PersonCheck
{    
    static void Main(string[] args)
    {
        string name;
        string age;
        string zodiacSign;
        string profession;

        Console.WriteLine("Ваше имя?");
        name = Console.ReadLine();
        Console.WriteLine("Ваш возраст?");
        age = Console.ReadLine();
        Console.WriteLine("Ваш знак зодиака?");
        zodiacSign = Console.ReadLine();
        Console.WriteLine("Ваша профессия?");
        profession = Console.ReadLine();

        Console.WriteLine("Вас зовут {0}, Вам {1}, Вы {2} и Ваша профессия {3}", name, age, zodiacSign, profession);
        Console.Read();
    }
}

