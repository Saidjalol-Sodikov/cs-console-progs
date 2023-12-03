Console.Write("Введите трёхзначное число: ");
int numMain = Convert.ToInt32(Console.ReadLine());
int sotni, edin, result;

sotni = numMain/100;
edin = numMain%10;

result = sotni*10+edin;
Console.WriteLine("Число, которое получено после операций: "+result);