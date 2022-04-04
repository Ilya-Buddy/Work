//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

//Создаем 2 массива. 
string[] array1 = new string[5] {"Bob", "Rob12", "hello", "Buddy", "Yo"};
string[] array2 = new string[array1.Length];

//Метод void, в котором цикле for проверка условия (длина строки <= 3). 
//Если да, то элемент первого массива заносится в count элемент второго массива. 
//Переменная count чтобы поочередно закидывать из первого массива во второй.
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

//Подготовка и вывод на печать.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);