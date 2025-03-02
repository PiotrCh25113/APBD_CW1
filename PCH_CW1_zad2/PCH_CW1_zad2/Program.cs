// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = { 3, 2, 5 };
double GetAverage(int[] numbers)
{   
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += numbers[i];
    }
    return sum/arr.Length;
}

double result = GetAverage(arr);

Console.WriteLine(result);