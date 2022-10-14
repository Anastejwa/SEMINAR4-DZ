// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33}
//Console.WriteLine(string.Join(", ", arr)); - вывод массива одной строкой

void FillArray(int[] array)
{
int length = array.Length;
int index = 0;
 while (index < length)
    {
        Console.WriteLine($"Введите элемент массива [{index}]:");
        int N = int.Parse(Console.ReadLine()!);
        array[index] = N;
        index++;
    }
}
void PrintArray(int[] arr)
{
int count = arr.Length;
int index = 0;
while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}
int[] array = new int[8];
int count = array.Length;

FillArray(array);
PrintArray(array);