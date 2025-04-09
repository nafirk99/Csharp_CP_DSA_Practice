using System.Reflection;
using ArrayPractice;

//---------------------------------------

//string Path = "F:\\Csharp_CP_DSA_Practice\\Array\\ArrayPractice\\DemoLibrary\\bin\\Debug\\net8.0\\DemoLibrary.dll";
//Assembly F = Assembly.LoadFile(Path);

//Type[] Rtypes = F.GetTypes();

//for (int i = 0; i < Rtypes.Length; i++)
//{
//    Console.WriteLine(Rtypes[i].Name);
//}

//Console.WriteLine($"Tiple F length: {Rtypes.Length}");

//List<int> ints = new List<int>();

//Type type = ints.GetType();

//---------------------------------------


//int[] a = new int[2];

//a[0] = 2; 

//a[1] = 3;

//for (int i = 0; i < a.Length; i++)
//{
//    //Console.WriteLine(a[i]);
//}

//int[] b = new int[] { 2, 3, 4, 5, 6 ,2,9,2,1,0};

//foreach (int i in b)
//{
//    Console.WriteLine(i);
//}

//for(int i=0; i<b.Length; i++)
//{
//    Console.WriteLine($"B using for : {b[i]}");
//}
//foreach (int i in b)
//{
//    Console.WriteLine($"b foreach: {i}");
//}

//Array.Sort(b);
//Console.WriteLine("Sorted:");
//foreach (int i in b)
//{
//    Console.WriteLine(i + " ");
//}
//Array.Reverse(b);
//Console.WriteLine("Reversed: ");
//foreach (int i in b)
//{
//    Console.WriteLine(i + " ");
//}


//var p = new Person()
//{
//    Id = 1,
//    Name = "Test",
//};

//Type type = typeof(Person);
//Type type2 = p.GetType();

//Assembly r = Assembly.GetExecutingAssembly();




//int[] numbers;
//numbers = new int[4];
//int[] numbers = { 1,2,3 };

//int[] studentScores = new int[4];
//studentScores[2] = 95;

//int[] intNumbers = { 1,2,35,6,6,6 };
//for(int i=0; i< intNumbers.Length; i++)
//{
//    Console.WriteLine(intNumbers[i]);
//}

//intNumbers[2] = 30;
//for (int i = 0; i < intNumbers.Length; i++)
//{
//    Console.WriteLine(intNumbers[i]);
//}

//Array.Sort(intNumbers);

//foreach(int i in numbers)
//{
//    Console.WriteLine(i);
//}

//int[] values = { 5, 12, 8, 20, 3 };
//Console.Write("Printing The Array Elements:");
//for(int i=0; i<values.Length; i++)
//{
//    Console.Write($"{values[i]},");
//}
//Console.WriteLine();

//Console.Write("Ascending Order:");
//Array.Sort(values);
//for(int i =0; i< values.Length; i++)
//{
//    Console.Write($"{values[i]},");
//}

//Console.WriteLine();
//Console.Write("Descending Order:");
//Array.Reverse(values);
//for(int i =0; i<values.Length; i++)
//{
//    Console.Write($"{values[i]},");
//}

//int[] array = { 1, 2, 3, 4, 5 };

//static int sumOfnumbers(int[] arr)
//{
//    int sum = 0;
//    for(int i=0; i<arr.Length; i++)
//    {
//        sum += arr[i];
//    }
//    return sum;
//}

//var result = sumOfnumbers(array);
//Console.WriteLine(result);

//int[] array2 = { 3, 12, 8, 20, 3 };

//static int findMaximum(int[] arr)
//{
//    int max = arr[0];
//    for(int i= 0; i<arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//    return max;
//}
//Console.Write("Max Is:");
//Console.WriteLine(findMaximum(array2));


//int[] arr3 = {5, 12, 8, 20, 3 };
//static int findMinimum(int[] arr)
//{
//    int min = arr[0];
//    for(int i = 0; i<arr.Length; i++)
//    {
//        if (arr[i] < min)
//        {
//            min = arr[i];
//        }
//    }
//        return min;
//}

//Console.Write("Minimum:");
//Console.WriteLine(findMinimum(arr3));

//int[] arr4 = { 1, 2, 3, 4, 5 };

//static double findAverage(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++) 
//    {
//        sum += arr[i];
//    }
//     double abv = (double) sum / arr.Length;
//    return abv;
//}

//Console.Write("Average: ");
//Console.WriteLine(findAverage(arr4));

//int[] arr5 = { 1, 2, 3, 4, 5, 6 };

//static int findEven(int[] arr)
//{
//    int count = 0;
//    for(int i=0; i<arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}

//Console.Write("Even: ");
//Console.WriteLine(findEven(arr5));

//int[] arr6 = { 1, 2, 3, 4, 5, 6 };

//static int countOddNumbers(int[] arr)
//{
//    int count = 0;
//    for(int i = 0; i<arr.Length; i++)
//    {
//        if (arr[i] % 2 != 0) 
//        { count++; }
//    }
//    return count;
//}

//Console.WriteLine(countOddNumbers(arr6));
int[] arr7 = { 10, 20, 30, 40, 50, 6 };

static int findIndex(int[] arr, int target)
{
    //if (arr == null)
    //{
    //    return -1; 
    //}

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i;
        }
    }
    return -1;
}

Console.WriteLine(findIndex(arr7, 6));
