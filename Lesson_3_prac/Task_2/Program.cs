//Введение начальных данных
Console.Write("Введите длину массива: ");
int arreySize = Convert.ToInt32(Console.ReadLine());

//Получение рабочего материала
int[] arrey = new int[arreySize];
Console.Write("Изначальный массив :");
for (int i = 0; i < arreySize; i++)
{
    arrey[i] = new Random().Next(-10, 10);
    Console.Write(arrey[i] + " ");
}
Console.WriteLine();

//Решение задачи
Console.Write("Отформатированный массив :");
for (int i = 0; i < arreySize; i++)
{
    Console.Write((arrey[i]*(-1)) + " ");              //Выведение результатов
}