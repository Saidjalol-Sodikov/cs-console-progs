Console.Write("Введите значение X:");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y:");
int numY = Convert.ToInt32(Console.ReadLine());

int result;

if (numX == 0 || numY == 0) {
    result = 0;
} 
else {
    if (numX > 0) {
        if (numY > 0) {
            result = 1;
        } 
        else {
            result = 4;
        }
   }
   else {
        if (numY > 0) {
           result = 2;
        } 
        else {
            result = 3;
        }
   }
}

if (result == 0) {
    Console.WriteLine("Вводите значения отличные от нуля");
} 
else {
    Console.WriteLine("Номер координатной четверти плоскости: "+result);
}