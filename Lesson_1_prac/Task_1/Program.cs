//Программа проверки квадрата первого входящего числа со вторым
//числом.

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int bSquar = b*b;

if (bSquar == a) {
    Console.Write("Да");
} else {
    Console.Write("Нет");
}