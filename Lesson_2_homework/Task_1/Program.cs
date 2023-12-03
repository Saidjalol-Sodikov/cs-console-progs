Console.Write("Введите число: ");
int numMain = Convert.ToInt32(Console.ReadLine());

if (numMain%7==0 && numMain%23==0) Console.WriteLine("Число кратно и 7, и 23");
else Console.WriteLine("Число не кратно 7 и 23");