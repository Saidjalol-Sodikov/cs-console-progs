int number = new Random().Next(1, 100);

////То, что ниже можно скопировать и вставить
if (number%2 == 0) {
    Console.WriteLine($"Число `{number}` чётное");
} else {
    Console.WriteLine("Число `"+number+"` нечётное");
}