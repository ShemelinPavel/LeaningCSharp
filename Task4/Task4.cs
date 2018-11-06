namespace Lesson1
{

    using System;
    using Lesson1ClassLibrary;

    class Task4
    {

        static void Main()
        {

            string Welcome = "Добрый день, пользователь\n";
            Welcome = Welcome + "Давайте обменяем два целых числа местами\n";
            Welcome = Welcome + "\n";

            Lesson1ClassLibrary.Print(Welcome);

            int A = Int32.Parse(Lesson1ClassLibrary.MakeQuestion("значение переменной A"));
            int B = Int32.Parse(Lesson1ClassLibrary.MakeQuestion("значение переменной B"));

            // обмен через 3-ю переменную
            int C = A;
            A = B;
            B = C;
                        
            Lesson1ClassLibrary.Print($"Результат обмена через 3-ю переменную: A = {A}, B = {B}");

            //обратный обмен без 3-ей переменной

            A = A + B;
            B = A - B;
            A = A - B;

            Lesson1ClassLibrary.Print($"Результат обмена без использования 3-ей переменной: A = {A}, B = {B}");

            Lesson1ClassLibrary.Pause();

        }

    }

}