/*Задача 2: Проверка на простое число:
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void Simple(int N, int D)
{
    if (N / D == 1)
    {
        Console.WriteLine("Является простым числом");
        return;
    }
    if (N % D != 0)
    {
        Simple(N, D + 1);
    }
    else Console.WriteLine("Не является простым числом");;
}

int N = Promt("Введите N => ");
Simple(N, 2);
