// Задача 34. Задайте массив заполненый случвйными 3х значными положительными числами. напишите программу, которая покажет количество четных чисел в массиве.
/*
Console.WriteLine("Enter the size of the array");
int size=Convert.ToInt32(Console.ReadLine()!);
int[] numbers=new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("This is array");
PrintArray (numbers);
int count=0;

for(int z=0; z<numbers.Length; z++)
if(numbers[z]%2==0)
count++;

Console.WriteLine($"{numbers.Length}, {count} are even numbers ");

void FillArrayRandomNumbers(int[]numbers)
{
   for(int i=0; i<numbers.Length; i++)
   {
      numbers[i]=new Random().Next(100,1000);
   }
}

void PrintArray(int[]numbers)
{
   Console.Write("[");
   for(int i=0; i<numbers.Length; i++)
   {
      Console.Write(numbers[i] + " ");
   }
   Console.Write("]");
   Console.WriteLine();
}
*/
//Задача 36.
/*
int size=ReadInt("Enter the size of the array: ");
int min=ReadInt("Enter minimum number of the array: ");
int max=ReadInt(" Enter maximum number of the array: ");
int[] numbers=new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result=0;

for(int i=0; i<numbers.Length; i++)
{
   if(i%2!=0)
   {
      result+=numbers[i];
   }
}
Console.WriteLine($"Sum of the alements on the even positions - {result}");

void FillArrayRandomNumbers(int[]array)
{
   for(int i=0; i<array.Length; i++)
   {
      array[i]=new Random().Next(min,max);
   }
}
void PrintArray(int[]array)
{
   for(int i=0; i<array.Length; i++)
   {
      Console.Write(array[i]+" ");
   }
   Console.WriteLine();
}

int ReadInt(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача 38
/*
Console.WriteLine("Enter the size of the array: ");
int n=Convert.ToInt32(Console.ReadLine());
int[]mass=new int[n];
Random rnd=new Random();
for(int i=0; i<n; i++)
{
   mass[i]=rnd.Next(-10,10);
   Console.Write($" {mass[i]} ");
}
int min=0;
int max=0;
foreach(int i in mass)
{
   if(min>i) min=i;
   if(max<i) max=i;
}
Console.WriteLine($"\n Max element: {max}\n Min element: {min}");
Console.WriteLine($"Difference between max i min element: {max-min}");
*/

