int a, b, c;

a = new Random().Next(1, 100);
b = new Random().Next(1, 100);
c = new Random().Next(1, 100);

//То, что ниже можно скопировать и вставить
int max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine(max);
