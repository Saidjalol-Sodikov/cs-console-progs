Console.Write("Введите чиcло: ");
int numMain = Convert.ToInt32(Console.ReadLine());
int sotni;
if (numMain/100==0) {
    Console.WriteLine("Третьей цифры справа нет.");
} else {
    numMain = Math.Abs(numMain);
    sotni = (numMain%1000-numMain%100)/100;
    Console.WriteLine("Третья цифры справа :"+sotni);
    }
if (numMain/100==0) {
    Console.WriteLine("Третья цифры слева нет.");
} else {
    numMain = Math.Abs(numMain);    
    while (numMain>=1000) {
        numMain = numMain / 10;
        }
    Console.WriteLine("Третья цифры слева :"+numMain%10);
    }
