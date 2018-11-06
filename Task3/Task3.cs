namespace Lesson1
{
    using System;
    using System.Text.RegularExpressions;
    using Lesson1ClassLibrary;

    class Task3
    {

        static double TwoPointDest(int[] point1, int[] point2)
        {

            return Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2));

        }

        static void Main()
        {

            string WelcomeText = "Добрый день, пользователь\n";
            WelcomeText = WelcomeText + "Давайте расчитаем расстояние между точками!\n";
            WelcomeText = WelcomeText + "\n";

            Lesson1ClassLibrary.Print(WelcomeText);

            string[] Point1AsText = Regex.Split(Lesson1ClassLibrary.MakeQuestion("координаты точки X разделенные пробелом"), " ");
            string[] Point2AsText = Regex.Split(Lesson1ClassLibrary.MakeQuestion("координаты точки Y разделенные пробелом"), " ");

            int[] Point1 = new int[2];
            int[] Point2 = new int[2];

            #region точка x1, y1
            Point1[0] = Int32.Parse(Point1AsText[0]);
            Point1[1] = Int32.Parse(Point1AsText[1]);
            #endregion

            #region точка x2, y2
            Point2[0] = Int32.Parse(Point2AsText[0]);
            Point2[1] = Int32.Parse(Point2AsText[1]);
            #endregion

            //формула:  r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)

            Lesson1ClassLibrary.Print("Результат вычисления расстояния: {0:F2}", Math.Sqrt(Math.Pow(Point2[0] - Point1[0], 2) + Math.Pow(Point2[1] - Point1[1], 2)));

            Lesson1ClassLibrary.Print("Результат вычисления расстояния: {0:F2}", TwoPointDest(Point1, Point2));

            Lesson1ClassLibrary.Pause();

        }


    }

}
