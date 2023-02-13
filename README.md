#Итоговый проект
1. БЛОК-СХЕМА![итог1](https://user-images.githubusercontent.com/119758211/218546108-5fd6a358-3558-4a23-a8a7-a47bd129b8a4.png)
#КОД НА C#
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
InputArray2(array); // вызываем метод, который заполнит второй массив
