//Введение начальных данных
Console.Write("Введите длину массива: ");
int arreySize = Convert.ToInt32(Console.ReadLine());

//Получение рабочего материала
int[] arrey = new int[arreySize];
Console.Write("Изначальный массив :");
for (int i = 0; i < arreySize; i++)
{
    arrey[i] = new Random().Next(1, 10);
    Console.Write(arrey[i] + " ");
}
Console.WriteLine();

//Решение
for (int i = 0; i < arreySize/2; i++)
{
    Console.Write((arrey[i] * arrey[(arreySize-1)-i]) + " "); //Выведение результатов
}
if(arreySize%2!=0) Console.WriteLine($"(элемент {arrey[arreySize/2]} не имеет пары)");