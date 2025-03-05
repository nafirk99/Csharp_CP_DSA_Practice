// See https://aka.ms/new-console-template for more information



int[] a = new int[2];

a[0] = 2; 

a[1] = 3;

for (int i = 0; i < a.Length; i++)
{
    //Console.WriteLine(a[i]);
}

int[] b = new int[] { 2, 3, 4, 5, 6 ,2,9,2,1,0};

foreach (int i in b)
{
    Console.WriteLine(i);
}

for(int i=0; i<b.Length; i++)
{
    Console.WriteLine($"B using for : {b[i]}");
}
foreach (int i in b)
{
    Console.WriteLine($"b foreach: {i}");
}

Array.Sort(b);
Console.WriteLine("Sorted:");
foreach (int i in b)
{
    Console.WriteLine(i + " ");
}
Array.Reverse(b);
Console.WriteLine("Reversed: ");
foreach (int i in b)
{
    Console.WriteLine(i + " ");
}