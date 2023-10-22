//•	Read an integer number N from the console
//•	After that read N integer numbers from the console, each on separate line
//•	Store the numbers in the array of integers
//•	Reverse the numbers in the array
//•	Print elements of the array on a single line, space-separated

int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
for (int index = 0; index < numbers.Length; index++)
{
    numbers[index] = int.Parse(Console.ReadLine());
}
for (int index = numbers.Length - 1; index >= 0; index--)
{
    Console.Write(numbers[index] + " ");
}
