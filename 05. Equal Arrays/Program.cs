//•	Read two arrays with the same length from the console
//•	Check whether they are identical or not
//o	If the arrays are identical, print: "Arrays are identical."
//o If the arrays are NOT identical, print: "Arrays are not identical."
//Note: Arrays are identical if their elements are equal. 

int[] numbers1= Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numbers2 =Console.ReadLine().Split().Select(int.Parse).ToArray();

bool isIdentical = true;

for (int index = 0; index <= numbers1.Length - 1; index++)
{
    if (numbers1[index] != numbers2[index])
    {
        isIdentical=false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }

}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
