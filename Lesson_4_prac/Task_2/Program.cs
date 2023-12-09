void makeArrayRand (int[] arrayName)
{
        for (int i = 0; i < arrayName.Length; i++)
    {
        arrayName[i] = new Random().Next(1, 101);
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
int findCurrentNum (int[] arrayName)
{
    int result = 0;
    for (int i = 0; i<arrayName.Length; i++)
    {
        if (arrayName[i]%7==0 && arrayName[i]%10==1) 
        {
            result++;
        }
    }
    return result;
}




Console.Write("Введите длину массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
makeArrayRand(array);
printArray(array);
Console.WriteLine("Чисел, которые кратны 7 и имеют в конце 1, в массиве выше: " + findCurrentNum(array));