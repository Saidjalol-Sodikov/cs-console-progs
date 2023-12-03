Console.Write("Введите чиcло: ");
int numMain = Convert.ToInt32(Console.ReadLine());
int sotni;
if (numMain/100==0) {
    Console.WriteLine("Третьей цифры нет.");
} else {
    sotni = (numMain%1000-numMain%100)/100;
    Console.WriteLine(sotni);
    }