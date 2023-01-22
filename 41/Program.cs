// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateArray(int count)                                    //создание массива заданной длины и его заполнение значениями, вручную пользователем
{
    int i = 0;
    int[] result = new int[count];
    while (i < count)
    {
        System.Console.WriteLine($"Введите {i + 1}-е значение массива");
        result[i] = Convert.ToInt32(Console.ReadLine());
        i = i + 1;
    }
    return result;
}
void PrintArray(int[] array)                                    //метод выведения значений на экран
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
int CountPositiveArrayElements(int[] array)                     //метод подсчета положительных значений в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) count = count + 1;
    }
    return count;
}
Console.Clear();
System.Console.WriteLine("Введите кол-во элементов, которые будут представлены в массиве");
int numElements = Convert.ToInt32(Console.ReadLine());
if (numElements > 1)
{
int[] MyArray = CreateArray(numElements);
PrintArray(MyArray);
int PosNumbers = CountPositiveArrayElements(MyArray);
System.Console.WriteLine($"{PosNumbers} - кол-во элементов, в заданном массиве, имеют положительные значения");
}
else
{
System.Console.WriteLine("Ошибка! Введенно некорректное значение для формирования массива");    
}