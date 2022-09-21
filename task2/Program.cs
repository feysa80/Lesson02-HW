// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num/10 > 10){
    while(num/10 > 99){
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра - {num % 10}");
} else {
    Console.WriteLine("Третьей цифры нет");
}
