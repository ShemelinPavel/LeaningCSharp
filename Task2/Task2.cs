namespace Lesson1
{
    using System;

    class Task2
    {

 
        static void Main()
        {
            string WelcomeText = "Добрый день, пользователь\n";
            WelcomeText = WelcomeText + "Давайте расчитаем показатель ИМТ.\n";
 
            Console.WriteLine(WelcomeText);

            Console.Write("Ваш рост в метрах: ");
            decimal Height = Decimal.Parse(Console.ReadLine());

            Console.Write("Ваш вес в кг: ");
            decimal Weight = Decimal.Parse(Console.ReadLine());

            //Console.WriteLine("")
            Console.WriteLine("Ваш ИМТ: {0:N2}", Weight / (Height * Height));

            Console.ReadKey();

        }

    }
}