void makeArrayRand (int[] arrayName)
{
    for (int i = 0; i < arrayName.Length; i++)
    {
        arrayName[i] = new Random().Next(1, 100);
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
int findSimpleNum (int[] arrayName)
{
    int[] simpleNum = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
    int result = 0;
    for (int i = 0;i<arrayName.Length;i++)
    {
        for (int k = 0; k < simpleNum.Length; k++)
        {
            if (simpleNum[k] == arrayName[i])
            {
                result++;
            }
            if (simpleNum[k] > arrayName[i]) 
            {
                k = simpleNum.Length;
            }
        }
    }
    return result;
}




Console.Write("Введите длину массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
makeArrayRand(array);
printArray(array);
Console.WriteLine("Простых чисел в массиве выше: " + findSimpleNum(array));