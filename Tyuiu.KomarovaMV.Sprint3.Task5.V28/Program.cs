using Tyuiu.KomarovaMV.Sprint3.Task5.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#3                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #5                                                                 *");
        Console.WriteLine("* Вариант #28                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Написать программу , которая вычисляет cумму сумм ряда                      *");
        Console.WriteLine("*  по формуле, при X=2                                                       *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("   3  12                                                                     *");
        Console.WriteLine("y= ∑  ∑   k^x/sin(k)                                                         *");
        Console.WriteLine("  i=1 k=1                                                                    *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        int x = 2;
        int i1 = 1;
        int i2 = 3;
        int k1 = 1;
        int k2 = 12;
        Console.WriteLine(ds.GetSumSumSeries(x, i1, k1, i2, k2));
    }
}