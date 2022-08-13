Console.Write(" Введите трёхзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
if (stringNumber.Length > 2)
{
    Console.WriteLine(" Третья цифра = " + stringNumber[2]);
}
else
{
    Console.WriteLine(" Третьей цифры нет. ");
}

