int number = new Random().Next(1, 100);

////То, что ниже можно скопировать и вставить
int i=1;
while (i<=number) {
    if (i%2==0) Console.Write(i+"\t");
    i++;
}