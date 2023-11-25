void ChainNTo1(int numberN) {
    if (numberN > 0) {
        Console.Write($"{numberN} ");
        numberN--;
        ChainNTo1(numberN);
    }
}

Console.Write("Введите натуральное число N: ");
ChainNTo1(Convert.ToInt32(Console.ReadLine()));