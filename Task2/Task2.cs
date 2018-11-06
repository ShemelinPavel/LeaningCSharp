/*
 
Shemelin Pavel

2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

*/

namespace Lesson1
{
    using System;
    using Lesson1ClassLibrary;

    class Task2
    {

 
        static void Main()
        {
            string WelcomeText = "Добрый день, пользователь\n";
            WelcomeText = WelcomeText + "Давайте расчитаем показатель ИМТ.\n";
 
            Lesson1ClassLibrary.Print(WelcomeText);

            decimal Height = Decimal.Parse(Lesson1ClassLibrary.MakeQuestion("ваш рост в метрах"));
            decimal Weight = Decimal.Parse(Lesson1ClassLibrary.MakeQuestion("ваш вес в кг"));

            Lesson1ClassLibrary.Print("Ваш ИМТ: {0:N2}", Weight / (Height * Height));

            Lesson1ClassLibrary.Pause();

        }

    }
}