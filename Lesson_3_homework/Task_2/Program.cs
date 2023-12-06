//Введение начальных данных
Console.Write("Введите длину массива: ");
int arreySize = Convert.ToInt32(Console.ReadLine());

//Получение рабочего материала
int[] arrey = new int[arreySize];
int result = 0;
for (int i = 0; i < arreySize; i++)
{
    arrey[i] = new Random().Next(1, 100);
    Console.Write(arrey[i] + " ");

    //Решение задачи
    if (arrey[i]%2==0) result++;
}
Console.WriteLine();

//Выведение результатов
Console.WriteLine("Количество чётных чисел в массиве выше: " + result);