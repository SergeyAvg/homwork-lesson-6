Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите диапазон генерируемых чисел массива: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

for(int i = 0; i < N; i++)
{
    array[i] = new Random().Next(min, max);
    Console.Write(array[i] + " ");
}

int temp = 0;
int sum = 0;
Console.WriteLine( " "); 
for(int i = 0; i < N / 2; i++)
{
    temp = array[i] + array[N - i -1];
    sum = sum + temp;
    Console.Write(temp + " ");
}

Console.WriteLine("Cумма произведений пар чисел: " + sum); 