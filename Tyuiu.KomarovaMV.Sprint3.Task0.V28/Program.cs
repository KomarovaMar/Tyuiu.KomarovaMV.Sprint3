using Tyuiu.KomarovaMV.Sprint3.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт#2                                                                  *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                          *");
        Console.WriteLine("* Задание #0                                                                *");
        Console.WriteLine("* Вариант #28                                                               *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                    *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                   *");
        Console.WriteLine("*Написать программу используя цикл for, которая вычисляет произведение ряда *");
        Console.WriteLine("*  по формуле, при X=0,25                                                   *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("  17                                                                        *");
        Console.WriteLine("p= П  (x^3*i)+2                                                             *");
        Console.WriteLine("  i=1                                                                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("*****************************************************************************");
        double x = 0.25;
        int i = 1;
        int j = 17;
        Console.WriteLine(ds.GetMultiplySeries(x,i,j));
    }
}