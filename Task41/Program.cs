// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите несколько чисел через пробел: ");

int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);


Console.WriteLine($"Кол-во элементов больше 0: {ArrNum(arr)}");

int ArrNum(int[] array)
{
  int count = 0;// счётчик а 0
  for (int i = 0; i < array.Length; i++)// циклом проходим по всему массиву
  {
    if (array[i] > 0)// проверяем если элемент больше 0 
    {
      count++;// то счётчик увеличиваем на 1
    }
  }
  return count;// по завершении цикла выводим счётчик
}

