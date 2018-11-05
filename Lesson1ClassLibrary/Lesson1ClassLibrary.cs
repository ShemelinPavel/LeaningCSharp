using System;

namespace Lesson1ClassLibrary
{
    public class Lesson1ClassLibrary
    {

        public static void Pause()
        {

            Console.ReadKey();

        }

        public static void Print(string Text)
        {

            Console.WriteLine(Text);

        }

        public static void Print(string Text, params object[] arg)
        {

            Console.WriteLine(Text, arg);

        }


    }

}
