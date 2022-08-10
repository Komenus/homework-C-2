Console.Clear();
Console.WriteLine("Введите трехзачное число ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA >= 100 && numberA < 1000 ) 
{
    numberA = numberA /10;
    Console.WriteLine("Вторая цифра числа " + " " + numberA % 10 );
}
else
{
    Console.WriteLine("Вы ввели некорректное число ");
}