// заполняем начальный массив
void InputArray(string[] array)
{
    Console.WriteLine("Введите данные ");
    for (int i = 0; i < array.Length; i++)
        array[i] = Console.ReadLine();
    Console.Clear();
    PrintArray(array); //переходим к выводу массива
}

// вывод массива
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(",  ", array.Select(x => String.Format("\"{0}\"", x)))}]"); 
}

// заполнение второго массива
void InputArray2(string[] array)
{
    int j = 0;
    string[] a = new string[SizeArray2(array)];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            a[j] = array[i];
            j++;
        }
    }
    PrintArray(a); //переходим к выводу массива
}

// размер второго массива
int SizeArray2(string[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            num++;
        }
    }
    return num;
}

Console.Clear();
Console.Write("Введите размер массива: "); //просим ввести размер начального массива
int n  = int.Parse(Console.ReadLine()); // ввод данных с помощью консоли
string[] array = new string[n]; // создаём начальный массив с заданным размером
InputArray(array); // вызываем метод, который заполнит начальный массив
InputArray2(array); // вызывваем метод, который заполнит второй массив

