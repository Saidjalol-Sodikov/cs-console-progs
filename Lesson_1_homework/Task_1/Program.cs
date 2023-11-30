int firstNumber;
int secondNumber;

firstNumber = new Random().Next(1, 100);
secondNumber = new Random().Next(1, 100);

//То, что ниже можно скопировать и вставить
if (firstNumber==secondNumber) {
    Console.WriteLine($"Введенные числа равны `{firstNumber}`");
} else {
    if (firstNumber<secondNumber) {
        Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
    } else {
        Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
    };
};