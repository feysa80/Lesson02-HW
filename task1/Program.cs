// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000){
    int num2 = (num % 100)/10;
    Console.WriteLine($"Вторая цифра числа {num} - {num2}");
} else {
    Console.WriteLine("Неправильный ввод");
}
