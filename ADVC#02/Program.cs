using System.Collections;

internal class Program
{

    public static int SumArrayList(ArrayList list)
    {
        int sum = 0;
        if (list != null)
        {
            for (int i = 0; i < list.Count; i++)
            {
                sum += (int)list[i];
            }
        }
        return sum;
    }

    public static void ReverseArrayList(ArrayList list)
    {
        int n = list.Count;
        for (int i = 0; i < n / 2; i++)
        {
            object temp = list[i];
           list[i] = list[n - 1 - i];
           list[n - 1 - i] = temp;
        }
    }
    public static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }
        return evenNumbers;
    }

    public static int FindFirstNonRepeatedChar(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

       
        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

   
        for (int i = 0; i < str.Length; i++)
        {
            if (charCount[str[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
    private static void Main(string[] args)
    {
        
        ArrayList list = new ArrayList(new int[] { 10,6,9,8,6 });

        ReverseArrayList(list);
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine( "----------------------------------------\t");

        List<int> evenNumbers = new List<int>() { 1, 2, 3, 4 };

        List<int> even = GetEvenNumbers(evenNumbers);

        foreach (int number in even)
        {
            Console.WriteLine(number + " ");
        }
    }
}