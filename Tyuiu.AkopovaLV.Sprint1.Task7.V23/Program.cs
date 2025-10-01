using Tyuiu.AkopovaLV.Sprint1.Task7.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* что бы решить уровнение:                                                *");
        Console.WriteLine("*                         2 ");
        Console.WriteLine("*            sinx      20x             2 ");
        Console.WriteLine("* z = x - 10      + ---------  + cos (x - y ) ");
        Console.WriteLine("*                        3 ");
        Console.WriteLine("*                      3x ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.WriteLine("Введите значение x :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y :");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("z = " + ds.Calculate(x, y));

        Console.ReadLine();
    }
}