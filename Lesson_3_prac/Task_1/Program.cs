//Введение начальных данных
Console.Write("Введите искомое число: ");
int searchNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива: ");
int arreySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Есть ли в массиве ниже искомое число?");

//Получение рабочего материала
int[] arrey = new int[arreySize];
for (int i = 0; i < arreySize; i++)
{
    arrey[i] = new Random().Next(1,10);
    Console.Write(arrey[i] + " ");
}
Console.WriteLine();

//Решение задачи
bool result = false;
for (int i = 0; i < arreySize; i++)
{
    if (arrey[i] == searchNum) result = true;
}

//Выведение результатов
if (result) Console.WriteLine("Да, искомое число присутствует.");
else Console.WriteLine("Нет, искомого числа в массиве нет.");