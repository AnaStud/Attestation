int result = 0;

void SumMToN(int numberM, int numberN) {
    if (numberM < numberN) {
        numberM++;
        result += numberM;
        SumMToN(numberM, numberN);
    }
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
result += M;
SumMToN(M,N);
Console.WriteLine(result);