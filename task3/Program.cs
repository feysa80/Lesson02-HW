// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите номер дня недели от 1 до 7, например 1 для понедельника, 2 для вторника и тп");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num < 8){
    if (num == 6 || num == 7){
        Console.WriteLine("Это выходной!");
    } else {
        Console.WriteLine("Это будний день!");
    }
} else {
    Console.WriteLine("Неправильный ввод");
}
