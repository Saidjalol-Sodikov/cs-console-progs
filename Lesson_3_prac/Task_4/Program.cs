//Введение начальных данных
Console.Write("Введите трёхзначное число: ");
int numMain = Convert.ToInt32(Console.ReadLine());

//Получение рабочего материала
int arreySize = 3;
int[] arrey = new int[arreySize];
numMain = Math.Abs(numMain);

//Решение
int result = 0;
if (numMain < 1000 && numMain > 99)
{
    for (int i = 0; i < arreySize; i++)
    {
        arrey[i] = numMain % 10;
        numMain = numMain / 10;
    }
} else
{
    result = -1;
}

//Выведение резудьтатов
if (result == -1) Console.WriteLine("Введено некорректное число.");
if (result == 0)
{
    for (int i = 0; i < arreySize; i++)
    {
        Console.Write(arrey[i] + " ");
    }
}