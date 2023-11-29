Console.Clear();
int numA, numB, result1;
double numC, numD, result0;
numA = new Random().Next(1, 10);
numB = new Random().Next(1, 10);
numC = numA;
numD = numB;

Console.Write("Значение первого числа: ");
Console.WriteLine(numA);
Console.Write("Значение второго числа: ");
Console.WriteLine(numB);

result1 = numA+numB;
Console.WriteLine("Сумма "+numA+" и "+numB+" равняется: "+result1);

result1 = numA*numB;
Console.WriteLine("Произведение "+numA+" и "+numB+" равняется: "+result1);

result1 = numA-numB;
Console.WriteLine("Вычитание "+numB+" из "+numA+" равняется: "+result1);

result0 = numC/numD;
Console.WriteLine("Деление "+numB+" на "+numA+" равняется: "+result0);