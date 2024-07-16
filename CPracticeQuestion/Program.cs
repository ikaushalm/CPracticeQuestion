using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.BackgroundColor=ConsoleColor.Green;
        //Checking Prime Number
        //Console.WriteLine("Hello, World!");
        //if (isPrime(23))
        //{
        //    Console.WriteLine("Number is Prime");
        //}
        //else
        //{
        //    Console.WriteLine("Number is not Prime");
        //}


        //checking Swapping
        int a = 10,
            b = 12;

        SwapNumbers(ref a, ref b);
        Console.WriteLine($"a:{a} value b:{b}");


        //checkginReverseString
        Console.WriteLine(ReverseString("I am bad"));
        Console.WriteLine(ReverseStringstringBuilder("I am bad"));


        Console.WriteLine(GetFactLoop(10));


        Predicate<int> IsEven = x => x % 2 == 0;
        Console.ReadKey();

        int terms = 5;
        for (int i = 0; i < terms; i++)
        {
            Console.Write($"{Fibonaci(i)} ");
        }
        Console.ReadKey();
    }

    public static bool isPrime(int num)
    {
        Console.WriteLine(Math.Sqrt(num));
        if (num <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;

    }
    public static string ReverseString(string input)
    {
        var k = input.ToCharArray();
        Array.Reverse(k);
        return new string(k);

    }

    public static string ReverseStringstringBuilder(string input)
    {
        var k = input.ToCharArray();
        StringBuilder stringBuilder = new StringBuilder();

        for (int start = k.Length - 1; start > -1; start--)
        {
            stringBuilder.Append(k[start]);
        }
        return new string(stringBuilder.ToString());
    }


    public static void SwapNumbers(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    public async Task<int> GetDataAsync()
    {
        await Task.Delay(1000);
        return 44;

    }
    public async Task CallAsyncMethod()
    {
        int result = await GetDataAsync();
        Console.WriteLine(result);
    }


    // get sum of all numbers in integer array
    public static int GetSum(int[] input)
    {
        return input.Where(x => x % 2 == 0).Sum(x => x);

    }


    public static int ReversNum(int num)
    {
        int revrsernum = 0;
        while (num != 0)
        {
            int firstnum = num % 10;
            revrsernum = revrsernum * 10 + firstnum;
            num = num / 10;
        }

        return revrsernum;
    }


    public static long GetFactorial(int num)
    {
        //getting factorial
        if (num == 0 || num==1)
        {   
            return 1;
        }
        return num * GetFactorial(num - 1);
    }
    public static int GetFactLoop(int num)
    {
        int fact = 1;
        if (num == 0)
        {
            return 1;
        }
        //5
        for(int k=num; k>=1; k--)
        {
            fact = fact * k;

        }
        return fact;
    }


    public static int Fibonaci(int num)
    {
        if (num <= 1)
        {
            return num;
        }
        else
        {
            return Fibonaci(num - 1) + Fibonaci(num - 2);
        }
    }







}