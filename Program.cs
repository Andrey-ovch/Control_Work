// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void PrintArray(string[] array)      // Метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void StringOfThreeChar(string[] array, string[] array1)     //Метод создания массива из строк с 3 символами
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[index] = array[i];
            index++;
        }
    }
}


string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer", "science", "Russia", "Denmark", "Kazan", "Tom", "Github", "435", "Peace", "000" };
string[] array2 = new string[array.Length];


StringOfThreeChar(array, array2);
PrintArray(array2);


