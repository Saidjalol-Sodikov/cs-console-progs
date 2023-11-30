Console.Write("Введите число : ");
int numNpos = Convert.ToInt32(Console.ReadLine());

int numNneg = numNpos*(-1);

while (numNneg <= numNpos) {
    Console.Write(numNneg+" ");
    numNneg ++;
};