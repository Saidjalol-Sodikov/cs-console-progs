//Введение начальных данных
Console.Write("Введите длину массива: ");
int arreySize = Convert.ToInt32(Console.ReadLine());

//Получение рабочего материала
double[] arrey = new double[arreySize];
double min = 101, max = -1, result = 0;
for (int i = 0; i < arreySize; i++)
{
    arrey[i] = new Random().Next(1, 10000);
    arrey[i] = arrey[i] / 100;
    Console.Write(arrey[i] + " ");

    //Решение задачи
    if (arrey[i] > max ) max = arrey[i];
    if (arrey[i] < min ) min = arrey[i];
}
result = max - min;
Console.WriteLine();

//Выведение результатов
Console.WriteLine("Разница между максимальным и минимальным элементами массива выше: " + result);