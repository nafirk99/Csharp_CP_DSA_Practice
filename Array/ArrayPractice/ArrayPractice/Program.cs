using System.Reflection;
using ArrayPractice;

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


string Path = "F:\\Csharp_CP_DSA_Practice\\Array\\ArrayPractice\\DemoLibrary\\bin\\Debug\\net8.0\\DemoLibrary.dll";
Assembly F = Assembly.LoadFile(Path);

Type[] Rtypes = F.GetTypes();

for (int i = 0; i< Rtypes.Length; i++)
{
    Console.WriteLine(Rtypes[i].Name);
}

Console.WriteLine($"Tiple F length: {Rtypes.Length}");