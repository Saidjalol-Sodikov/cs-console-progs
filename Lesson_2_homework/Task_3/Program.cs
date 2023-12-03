//Adding part
Console.Write("Введите число в от 10 до 99: ");
int numMain = Convert.ToInt32(Console.ReadLine());

int result = -3, desaytki, edenits;
//Main code
if (numMain>=10 && numMain<=99){
    desaytki = (numMain-numMain%10)/10;
    edenits = numMain%10;
    if (desaytki>edenits) result=desaytki;
    if (desaytki<edenits) result=edenits;
    if (desaytki==edenits) result=-2;
} 
else {
    result = -1;
}
//Show results
if (result == -1) Console.WriteLine("Необходимо вводить число в правильном диапазоне");
if (result >= 0)  Console.WriteLine("Большая цифра числа выше: "+result);
if (result == -2) Console.WriteLine("Обе цифры числа выше равны");