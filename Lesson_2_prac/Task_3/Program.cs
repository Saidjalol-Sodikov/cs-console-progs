Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Является ли второе число кратным первому?");
if ((num1%num2)!=0) {
    Console.Write("Нет, "+num1%num2);
} else {
    Console.Write("Да");
}