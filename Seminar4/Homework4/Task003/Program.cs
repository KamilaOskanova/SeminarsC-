// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array)
{
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        Console.Write("Введите {0} элемент массива ", i + 1);
        array[i] = int.Parse(Console.ReadLine());
    }
}
int[] arr = new int[8];
PrintArray(arr);
Console.Write("Элементами массива являются ");
for (int k = 0; k < 8; k++) Console.Write($" {arr[k]} ");