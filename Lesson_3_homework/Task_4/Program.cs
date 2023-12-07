//Введение начальных данных
Console.Write("Введите число от 1 до 100000 :");
int numMain = Convert.ToInt32(Console.ReadLine());

//Получение рабочего материала
int arraySize = 0, numTemp = numMain; 
for (;numTemp > 0; numTemp=numTemp/10) {
    arraySize++;
}
int[] array = new int[arraySize];
numTemp = numMain;

//Решение задачи
for (int i = 0; i < arraySize; i++) {
    array[i] = numTemp/Convert.ToInt32(Math.Pow(10, arraySize-1-i));
    numTemp = numTemp - array[i]*Convert.ToInt32(Math.Pow(10, arraySize-1-i));
}

//Выведение результатов
for (int i = 0; i < arraySize; i++) {
    Console.Write(array[i]+" ");
}