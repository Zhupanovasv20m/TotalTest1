// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] TextArray = { "Солнце=)", "Море", "123", "лот" };
PrintResult(TextArray);

string[] FindShorttextInArr(string[] array)
{

}


void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
    else
        System.Console.WriteLine("Array is empty");
}

void PrintResult(string[] array)
{
     PrintArray(array);
    string[] shortArray = FindShorttextInArr(array);
    PrintArray(shortArray);
}