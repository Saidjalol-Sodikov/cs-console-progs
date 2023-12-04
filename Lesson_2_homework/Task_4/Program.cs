Console.Write("Введите число :");
int numMain = Convert.ToInt32(Console.ReadLine());

while (numMain>10) {
    int numDec = numMain;
    int counter = 0;
    while (numDec>=10) {
        numDec = numDec / 10;
        counter++;
    }
    Console.Write(numDec+", ");
    numMain = numMain - numDec*Convert.ToInt32(Math.Pow(10, counter));
}
Console.WriteLine(numMain);