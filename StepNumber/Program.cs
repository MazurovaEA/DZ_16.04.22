/*Задача 1: Определите, является ли число степенью двойки: N = 16 -> "Является степень двойки" 
N = 12 -> “Не является степенью двойки”*/
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void Del(int N)
{
    if (N / 2 == 0)
    {
        Console.WriteLine("Является степенью двойки");
        return;
    }
    if (N % 2 == 0)
    {
        Del(N / 2);
    }
    else { Console.WriteLine("Не является степенью двойки"); }

}

int N = Promt("Введите N => ");
Del(N);
