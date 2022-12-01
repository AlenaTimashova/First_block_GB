/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
*/

string[] ChangeArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 3 || array[i].Length == 3)             
            count++;
    
    string[] newArray = new string[count];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 3 || array[i].Length == 3)
        {
            newArray[j] = array[i];
            j++;
        } 
    }

    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Iput number of elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Input element {i + 1} of the array: ");
    array[i] = Console.ReadLine();;
}

string[] myArray = ChangeArray(array);
PrintArray(myArray);