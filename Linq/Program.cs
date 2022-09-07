// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] ints = new int[]
{
    2472,   7071,   3332,   5745,   7982,
    9164,   3909,   4380,   4000,   7862,
    6058,   9429,   2425,   7746,   5152,
    4031,   3701,   8970,   8856,   3526,
    6431,   7059,   7470,   6268,   6122
};

/*var average = ints.Average();
Console.WriteLine(average);

var oddInts = ints.Where(x => x % 2 == 0);
Console.WriteLine(oddInts.Average());
*/

var average = ints.Where(x => x % 2 != 0).Average();
Console.WriteLine(average);


