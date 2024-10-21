using Tyuiu.KomarovaMV.Sprint3.Task7.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#3                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #6                                                                 *");
        Console.WriteLine("* Вариант #10                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Напишите программу, которая выводит таблицу значений функции                *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        int x = -5;
        int y = 5;
        Console.WriteLine("Начальный шаг="+x);
        Console.WriteLine("Конечный шаг=" + y);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|     X    |   F(X)   |");
        Console.WriteLine("+----------+----------+");
        int len = y - x + 1;
        double[] res=new double[len];
        res=ds.GetMassFunction(x, y);
        for (int i = 0; i <= res.Length-1; i++)
        {
            Console.WriteLine("| {0,5:d}    |  {1,5:f2}   |",x,res[i]);
            x++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}