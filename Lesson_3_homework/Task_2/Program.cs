//Введение начальных данных
int arreySize = 10;
Console.WriteLine("Длина массива: "+arreySize);

//Получение рабочего материала
int[] arrey = new int[arreySize];
int result = 0;
for (int i = 0; i < arreySize; i++)
{
    Console.Write($"Введите элемент массива {i+1}: ");
    arrey[i] = Convert.ToInt32(Console.ReadLine());
    
    //Решение задачи
    if (arrey[i]%2==0) result++;
}

//Выведение результатов
Console.WriteLine("Количество чётных чисел в массиве выше: " + result);