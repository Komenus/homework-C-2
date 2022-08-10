Console.Clear();
Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 100)
{
     Console.WriteLine("Третьей цифры нет ");
}
else while(numberA >= 1000)
{
    numberA = numberA / 10;
}
if (numberA > 100)
{
numberA = numberA - numberA / 100 * 100;
numberA = numberA - numberA / 10 * 10;
Console.WriteLine("Третья цфира " + " " + numberA);
}