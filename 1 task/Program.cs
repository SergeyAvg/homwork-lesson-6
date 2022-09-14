Console.WriteLine("Введите длинну массива");
int N = Convert.ToInt32(Console.ReadLine()); // длинв массива
int [] array = new int [N];  // создаем массив с длинной N

// Заполнить массив
int index = 0;
int num = 1;
while (index < N)
{
    int m = Int32.Parse(Console.ReadLine());
    array[index] = m;
    index++;
    num++;
}

int count = 0;
for (int i = 0; i < N; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввел {count} положительных числа");