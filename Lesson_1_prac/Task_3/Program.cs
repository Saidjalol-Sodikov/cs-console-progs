bool term = true;
while (term) {
Console.Write("Введите трёхзначное число: ");
int numMain = Convert.ToInt32(Console.ReadLine());
if (numMain==0) term = false;
int sotni, edin, sum1and3;

sotni = numMain/100;
edin = numMain%10;

sum1and3 = sotni + edin;
Console.WriteLine("Сумма первой и третьей цифры числа сверху: "
+sum1and3);
}