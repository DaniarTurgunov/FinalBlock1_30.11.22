// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальый массив можно ввести с клавиатуры,
// либо задать на старте выполненения алгоритма.
Console.WriteLine("Введите размер массива");
int numN = Convert.ToInt32(Console.ReadLine());
string [] array = new string [numN];
fillArray(array);
printArray(array);
NewArray(array);
void fillArray (string [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение {i+1} элемента");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
}
void printArray(string [] array)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
        Console.Write($", {array[i]}");
    Console.WriteLine($"]");
    Console.WriteLine();
}
void NewArray(string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]}" + " ");
        }
    }
    Console.Write("]");
Console.WriteLine();
}

// 2 variant
Console.WriteLine("Введите размер массива");
int numN = Convert.ToInt32(Console.ReadLine());
string [] array = new string [numN];
string [] arr = new string [numN];
fillArray(array);
NewArr(arr);
printArray(array);
printArray(arr);
void fillArray (string [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение {i+1} элемента");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
}
void printArray(string [] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"]");
    Console.WriteLine();
}
void NewArr(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[i] = array[i];
        }
    }
}
