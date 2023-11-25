int AccermansFunction(int numberM, int numberN)
{
  if (numberM == 0)
    return numberN + 1;
  else
    if ((numberM != 0) && (numberN == 0))
      return AccermansFunction(numberM - 1, 1);
    else
      return AccermansFunction(numberM - 1, AccermansFunction(numberM, numberN - 1));
}

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A(m,n) = {AccermansFunction(m, n)}");