namespace Lesson1
{
    using System;

    class Task1
    {

        static string MakeQuestion(string questionText)
        {

            Console.Write("Введите " + questionText + ":");

            return Console.ReadLine();

        }

        static void PrintForm(string fName, string lName, string age, string height, string weight)
        {

            Console.WriteLine("Ваши данные:");

            Console.WriteLine("Имя: " + fName + ". Фамилия: " + lName + ". Возраст: " + age + ". Рост: " + height + ". Вес: " + weight + ".");

            Console.WriteLine("Имя: {0}. Фамилия: {1}. Возраст: {2}. Рост: {3:N2}. Вес: {4:N2}.", fName, lName, age, Decimal.Parse(height), Decimal.Parse(weight));

            Console.WriteLine($"Имя: {fName}. Фамилия: {lName}. Возраст: {age}. Рост: {height}. Вес: {weight}.");


        }

        static void Main()
        {
            string WelcomeText = "Добрый день, пользователь\n";
            WelcomeText = WelcomeText + "Для составления анкеты Вам будут предложены несколько вопросов.\n";
            WelcomeText = WelcomeText + "Давайте начнем!\n";
            WelcomeText = WelcomeText + "\n";

            Console.WriteLine(WelcomeText);

            string FirstName = MakeQuestion("Ваше имя");
            string LastName = MakeQuestion("Вашу фамилию");
            string Age = MakeQuestion("Ваш возраст");
            string Height = MakeQuestion("Ваш рост");
            string Weight = MakeQuestion("Ваш вес");

            PrintForm(FirstName, LastName, Age, Height, Weight);

            Console.ReadKey();

        }

    }
}