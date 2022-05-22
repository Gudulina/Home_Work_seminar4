// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Function(int A, int B)
{
    int Count = A;
    if (B==0) return 1;
    else
        if (B==1) return A;
        else
            for (int i = 1; i < B; i++)
            {
                Count *= A;
            }
        return Count;
}

Console.WriteLine(Function(3, 0));
Console.WriteLine(Function(2, 1));
Console.WriteLine(Function(4, 5));
