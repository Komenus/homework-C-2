Console.Clear();
Console.WriteLine("Введите порядковый номер дня недели ");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA == 6 || numberA == 7)
{
    Console.WriteLine("Этот порядковый номер соотвествует выходному дню ");
}
else if(numberA >7)
{
    Console.WriteLine("В неделе 7 дней !");
}
else 
{
    Console.WriteLine("Этот порядковый номер  не соотвествует выходному дню ");
}
