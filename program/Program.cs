// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Введите исходный массив строк
Console.Write("Введите элементы массива через запятую: ");
string[] sourceArray = Console.ReadLine()!.Split(',');

// Создайте новый массив строк, содержащий элементы исходного массива,
// которые имеют длину не больше 3 символов
int newArrayLength = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        newArrayLength++;
    }
}

string[] newArray = new string[newArrayLength];
int index = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        newArray[index] = sourceArray[i];
        index++;
    }
}

// Выведите новый массив строк
Console.WriteLine("Новый массив строк: ");
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}

Console.ReadKey();