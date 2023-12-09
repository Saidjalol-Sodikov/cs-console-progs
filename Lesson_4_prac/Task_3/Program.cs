void makeArrayRand (int[] arrayName)
{
        for (int i = 0; i < arrayName.Length; i++)
    {
        arrayName[i] = new Random().Next(0, 10);
    }
}
void printArray (int[] arrayName)
{
    Console.WriteLine("Рандомизированный массив состоит из: ");
    for (int i = 0;i < arrayName.Length-1;i++)
    {
        Console.Write(arrayName[i]+" ");
    }
    Console.WriteLine(arrayName[arrayName.Length - 1]);
}
int makeNumFromArray (int[] arrayName)
{
    int result = 0;
    for (int i = 0; i < arrayName.Length; i++)
    {
        result = result * 10 + arrayName[i];
    }
    return result;
}
// Введение данных
Console.Write("Введите длину массива [1-8]: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 8 && arraySize >= 1) 
{
    // Получение рабочего материала при корректном введении
    int[] array = new int[arraySize];
    makeArrayRand(array);
    printArray(array);

    // Выведение результата
    Console.WriteLine("Полученное число: " + makeNumFromArray(array));
}
else
{ 
    // Некорректное введение данных
    Console.WriteLine("Введено некоректное значение");
} 

