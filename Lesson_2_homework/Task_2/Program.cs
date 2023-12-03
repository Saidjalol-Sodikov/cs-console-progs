Console.Write("Введите значение X:");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y:");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX == 0 || numY == 0) {
    Console. WriteLine("Вводите значения отличные от нуля");
} 
else {
    if (numX > 0) {
        if (numY > 0) {
            Console.WriteLine("Точка находиться на координатной четверти 1");
        } 
        else {
            Console.WriteLine("Точка находиться на координатной четверти 4");
        }
   }
   else {
        if (numY > 0) {
           Console.WriteLine("Точка находиться на координатной четверти 2");
        } 
        else {
            Console.WriteLine("Точка находиться на координатной четверти 3");
        }
   }
}