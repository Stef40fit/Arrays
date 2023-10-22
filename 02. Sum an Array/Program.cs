//•	Read an array of integers (from a single line separated with a space)
//•	Print the sum of all elements in the given array

int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = 0;
for(int index = 0; index <= numbers.Length -1; index++)
{
    sum += numbers[index];
}
Console.WriteLine(sum);