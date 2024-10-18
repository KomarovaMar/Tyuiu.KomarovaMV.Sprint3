using Tyuiu.KomarovaMV.Sprint3.Task4.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#3                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #4                                                                 *");
        Console.WriteLine("* Вариант #4                                                                 *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение функции *");
        Console.WriteLine("*y=x/(cos(x)+sin(x)). При х = 0 прервать цикл. Полученные значения           *");
        Console.WriteLine("*суммировать.                                                                *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        int x = -5;
        int y = 5;
        Console.WriteLine(ds.Calculate(x, y));
    }
}