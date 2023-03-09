// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.Clear();

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);


// double x = (b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)// создаём функцию, которая возвращает  массив вещественных чисел, а на вход принимает вещественные числа
{
  double[] result = new double[2];// создали массив вещественных чисел на 2 элемента (double[2])
  result[0] = (inB2 - inB1) / (inK1 - inK2);// в 0 индекс массива (X) положили действие формулы
  result[1] = inK1 * result[0] + inB1;// в первый индекс ассива (Y) так же положили действие формулы 
  return result;// выводим результат
}

Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

// Console.WriteLine($"Пересечение в точке: ({x:f2}; {y:f2})");
