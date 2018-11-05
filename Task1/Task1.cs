namespace Lesson1
{
    using System;
    using Lesson1ClassLibrary;

    class Task1
    {

        static void PrintForm(string fName, string lName, string age, string height, string weight)
        {

            Lesson1ClassLibrary.Print("Ваши данные:");

            Lesson1ClassLibrary.Print("Имя: " + fName + ". Фамилия: " + lName + ". Возраст: " + age + ". Рост: " + height + ". Вес: " + weight + ".");

            Lesson1ClassLibrary.Print("Имя: {0}. Фамилия: {1}. Возраст: {2}. Рост: {3:N2}. Вес: {4:N2}.", fName, lName, age, Decimal.Parse(height), Decimal.Parse(weight));

            Lesson1ClassLibrary.Print($"Имя: {fName}. Фамилия: {lName}. Возраст: {age}. Рост: {height}. Вес: {weight}.");


        }

        static void Main()
        {
            string WelcomeText = "Добрый день, пользователь\n";
            WelcomeText = WelcomeText + "Для составления анкеты Вам будут предложены несколько вопросов.\n";
            WelcomeText = WelcomeText + "Давайте начнем!\n";
            WelcomeText = WelcomeText + "\n";

            Lesson1ClassLibrary.Print(WelcomeText);

            string FirstName = Lesson1ClassLibrary.MakeQuestion("Ваше имя");
            string LastName = Lesson1ClassLibrary.MakeQuestion("Вашу фамилию");
            string Age = Lesson1ClassLibrary.MakeQuestion("Ваш возраст");
            string Height = Lesson1ClassLibrary.MakeQuestion("Ваш рост");
            string Weight = Lesson1ClassLibrary.MakeQuestion("Ваш вес");

            PrintForm(FirstName, LastName, Age, Height, Weight);

            Lesson1ClassLibrary.Pause();

        }

    }
}