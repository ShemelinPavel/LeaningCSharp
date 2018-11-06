/*
 
Shemelin Pavel

5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

*/

namespace Lesson1
{
    using System;
    using Lesson1ClassLibrary;

    class Task5
    {

        static void Print(string message, int x, int y)
        {

            Console.SetCursorPosition(x, y);

            Lesson1ClassLibrary.Print(message);

        }


        static void Main()
        {
            string WelcomeText = "Добрый день, пользователь\n";
            WelcomeText = WelcomeText + "Соберем данные и выведем в центре экрана.\n";
            WelcomeText = WelcomeText + "\n";

            Lesson1ClassLibrary.Print(WelcomeText);

            string FirstName = Lesson1ClassLibrary.MakeQuestion("ваше имя");
            string LastName = Lesson1ClassLibrary.MakeQuestion("вашу фамилию");
            string City = Lesson1ClassLibrary.MakeQuestion("ваш город");

            string Message = $"Имя: {FirstName}. Фамилия: {LastName}. Город {City}";

            int ColsoleWindowHeight = Console.WindowHeight;
            int ColsoleWindowWidth = Console.WindowWidth;

            //середина экрана

            int ColsoleWindowHalfHeight = ColsoleWindowHeight / 2;
            int ColsoleWindowHalfWidth = ColsoleWindowWidth / 2;

            //учет длины строки анкеты
            int ColsoleWindowStartWidth = ColsoleWindowHalfWidth - Message.Length / 2;
            if (ColsoleWindowStartWidth < 0)
            {
                ColsoleWindowStartWidth = 0;
            }

            //вывод в середину экрана

            Console.SetCursorPosition(ColsoleWindowStartWidth, ColsoleWindowHalfHeight);
            Console.WriteLine(Message);

            //вывод в середину через свой метод, чтобы было видно - сместимся на одну строку вниз

            Print(Message, ColsoleWindowStartWidth, ColsoleWindowHalfHeight +1);

            Lesson1ClassLibrary.Pause();

        }

    }
}