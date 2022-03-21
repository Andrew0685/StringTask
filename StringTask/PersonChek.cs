using System;


class PersonCheck
{    
    static void Main(string[] args)
    {
        string name = "Ваше имя?";
        string age = "Ваш возраст?";
        string zodiac = "Ваш знак зодиака?";
        string profession = "Ваша профессия?";

        Console.WriteLine(name);
        name = Console.ReadLine();
        Console.WriteLine(age);
        age = Console.ReadLine();
        Console.WriteLine(zodiac);
        zodiac = Console.ReadLine();
        Console.WriteLine(profession);
        profession = Console.ReadLine();

        Console.WriteLine("Вас зовут {0}, Вам {1}, Вы {2} и Ваша профессия {3}", name, age, zodiac, profession);
        Console.Read();
    }
}

