using System;

namespace Lesson1ClassLibrary
{
    public class Lesson1ClassLibrary
    {

        public static void Pause()
        {

            Console.ReadKey();

        }

        public static void Print(string Text, bool EndOfString = true)
        {

            if (EndOfString)
            {
                Console.WriteLine(Text);
            }
            else
            {
                Console.Write(Text);
            }

        }

        public static void Print(string Text, params object[] arg)
        {

            Console.WriteLine(Text, arg);

        }

        public static string MakeQuestion(string questionText)
        {

            Print("Введите " + questionText + " : ", false);

            return Console.ReadLine();

        }




    }

}
