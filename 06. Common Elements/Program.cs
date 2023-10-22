//•	Read two integer arrays with the same length from the console
//•	Prints common elements in two arrays, space-separated



using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

//for (int index = 0; index <= numbers1.Length - 1; index++)
//{
//    if (numbers1[index] == numbers2[index])
//    {

//        Console.Write(numbers1[index] + " ");
//    }
//}
//foreach (int index1 in numbers1)
//{
//    foreach (int index2 in numbers2)
//    {
//        if (numbers1[index1] == numbers2[index2])
//        {

//            Console.Write(numbers1[index1] + " ");
//        }
//    }
//}


//ВАРИАНТ1

//foreach (int num1 in numbers1)
//{
//    if (numbers2.Contains(num1))
//    {
//        Console.Write(num1 + " ");
//    }
//}
// ВАРИАНТ2
for (int i = 0; i < numbers1.Length; i++)
{
    for (int j = 0; j < numbers2.Length; j++)
    {
        if (numbers1[i] == numbers2[j])
        {
            Console.Write(numbers1[i] + " ");
            break; // Exit the inner loop once a common element is found
        }
    }
}





