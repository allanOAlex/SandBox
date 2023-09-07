using System.Dynamic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;
using SandBox.Console;

public partial class Program
{
    public static void Main()
    {
        bool isValid = false;

        #region Fibonacci

        //Console.WriteLine("Enter number");
        //int n = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Fibonacci Sequence:");
        //for (int i = 0; i < n; i++)
        //{
        //    int fibNumber = Methods.Fibonacci(i);
        //    Console.WriteLine();
        //    Console.Write(fibNumber + " ");
        //    Console.ReadKey();
        //}

        #endregion

        #region DoTheyBelong

        //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int x1 = Convert.ToInt32(Console.ReadLine().Trim());
        //int y1 = Convert.ToInt32(Console.ReadLine().Trim());
        //int x2 = Convert.ToInt32(Console.ReadLine().Trim());
        //int y2 = Convert.ToInt32(Console.ReadLine().Trim());
        //int x3 = Convert.ToInt32(Console.ReadLine().Trim());
        //int y3 = Convert.ToInt32(Console.ReadLine().Trim());
        //int xp = Convert.ToInt32(Console.ReadLine().Trim());
        //int yp = Convert.ToInt32(Console.ReadLine().Trim());
        //int xq = Convert.ToInt32(Console.ReadLine().Trim());
        //int yq = Convert.ToInt32(Console.ReadLine().Trim());
        //int result = DoTheyBelong.PointsBelong(x1, y1, x2, y2, x3, y3, xp, yp, xq, yq);

        //textWriter.WriteLine(result);
        //textWriter.Flush();
        //textWriter.Close();

        #endregion

        #region StringToXML

        //string input = Console.ReadLine();

        //Methods.StringwithTagsToXML();
        //Methods.PlainStringToXML(input);

        //Console.ReadKey();

        #endregion

        #region StoreLoss

        //Console.WriteLine("Enter Average Cost Price ");
        //decimal averageCostPrice = Convert.ToDecimal(Console.ReadLine().Trim());

        //Console.WriteLine("Enter Average Selling Price ");
        //decimal averageSellingPrice = Convert.ToDecimal(Console.ReadLine().Trim());

        //Console.WriteLine("Enter Amount Stolen ");
        //decimal amountStolen = Convert.ToDecimal(Console.ReadLine().Trim());

        //Console.WriteLine("Enter Amount Spent ");
        //decimal amountSpent = Convert.ToDecimal(Console.ReadLine().Trim());


        //Methods.StoreLoss(averageCostPrice, averageSellingPrice, amountStolen, amountSpent);
        //Console.ReadKey();

        #endregion

        #region CheckIfArrayContainsInterger

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter Length Of the integer Array");

        //int arrayLength = int.Parse(Console.ReadLine());
        //int[] array = new int[arrayLength];

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Populate the Array with intergers");

        //for (int i = 0; i < arrayLength; i++)
        //{
        //    array[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter the Integer to check for");

        //int intValue = Convert.ToInt32(Console.ReadLine());
        //bool containsInt = Methods.CheckIfArrayContainsInt(array, intValue);

        //if (containsInt == true)
        //{
        //    Console.WriteLine(string.Empty);
        //    Console.WriteLine("Array contains the integer");
        //    return;
        //}

        //Console.WriteLine("Array does not contains the integer");
        //return;


        #endregion

        #region ComputeClosetToZero

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter Length Of the integer Array");
        //int lengthOfArry = int.Parse(Console.ReadLine());

        //int[] temps = new int[lengthOfArry];

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Populate the Array with integers, separated by spaces");
        //string inputString = Regex.Replace(Console.ReadLine(), @"\s+", " ");
        //string[] inputs = inputString.Split(' ');

        //for (int i = 0; i < lengthOfArry; i++)
        //{
        //    temps[i] = int.Parse(inputs[i]);
        //}

        //var stdOutWriter = Console.Out;
        //Console.SetOut(Console.Error);

        //int closestToZero = Methods.ComputeClosestToZero(temps);

        //Console.SetOut(stdOutWriter);
        //Console.WriteLine(string.Empty);
        //Console.WriteLine($"The integer, in the array, that is closest to zero is: {closestToZero}");

        //#endregion

        //#region ReturnSmallestPOsitiveInteger

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter Length Of the integer Array");
        //int lengthOfArry = int.Parse(Console.ReadLine());

        //int[] temps = new int[lengthOfArry];

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Populate the Array with integers, separated by spaces");
        //string inputString = Regex.Replace(Console.ReadLine(), @"\s+", " ");
        //string[] inputs = inputString.Split(' ');

        //for (int i = 0; i < lengthOfArry; i++)
        //{
        //    temps[i] = int.Parse(inputs[i]);
        //}

        //var stdOutWriter = Console.Out;
        //Console.SetOut(Console.Error);

        //int closestToZero = Methods.ComputeClosestToZero(temps);

        //Console.SetOut(stdOutWriter);
        //Console.WriteLine(string.Empty);
        //Console.WriteLine($"The integer, in the array, that is closest to zero is: {closestToZero}");


        #endregion

        #region Pallindrome

        //string input = Console.ReadLine();
        //bool isPalindrome = Methods.CheckIfStringIsPalindrome(input);
        //Console.WriteLine(isPalindrome);

        //int stringIsPalindrome = Methods.StringIsPalindrome(input);
        //if (stringIsPalindrome == 1)
        //{
        //    Console.WriteLine($"Input value: {input} is a palindrome string");
        //}
        //else
        //{
        //    Console.WriteLine($"Input value: {input} is not a palindrome string");
        //}

        //Methods.IsPalindrome(input);
        //Methods.ReverseString(input);
        //Methods.IsPalindromeString(input);
        //Methods.Palindrome(input);

        #endregion

        #region Pallindrome Indices

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter integer value ");

        //int n = Convert.ToInt32(Console.ReadLine());

        //var strings = new List<string>();

        //for (int i = 0; i < n; i++)
        //{
        //    if (i > 0)
        //    {
        //        Console.WriteLine("Enter another string value");
        //    }
        //    if (i <= 0)
        //    {
        //        Console.WriteLine("Enter string value");
        //    }

        //    strings.Add(Console.ReadLine().Trim().ToLower());
        //}

        //var palindromeIndices = new List<int>();

        //foreach (string item in strings)
        //{
        //    int palindromeCharIndex = -1;

        //    if (!Methods.IsPalindrome(item))
        //    {
        //        int i = 0, j = item.Length - 1;
        //        char currentChar, lastChar;

        //        while (j >= i)
        //        {
        //            currentChar = item[i];
        //            lastChar = item[j];

        //            if (currentChar != lastChar)
        //            {
        //                string skipRight = item.Substring(i, item.Length - (i * 2) - 1);
        //                string skiptLeft = item.Substring(i + 1, item.Length - 1 - (i * 2));

        //                if (Methods.IsPalindrome(skipRight))
        //                {
        //                    palindromeCharIndex = j;
        //                    break;
        //                }
        //                else if (Methods.IsPalindrome(skiptLeft))
        //                {
        //                    palindromeCharIndex = i;
        //                    break;
        //                }
        //            }
        //            i++;
        //            j--;
        //        }
        //    }

        //    palindromeIndices.Add(palindromeCharIndex > -2 ? palindromeCharIndex : -9999);
        //}

        //palindromeIndices.ForEach(d => Console.WriteLine(d));

        //Console.ReadKey();

        #endregion

        #region ClosestNumbers

        //int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());
        //List<int> numbers = new List<int>();

        //for (int i = 0; i < numbersCount; i++)
        //{
        //    int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
        //    numbers.Add(numbersItem);
        //}
        //Console.WriteLine("Hello World!");

        #endregion

        #region FilterWords That Conatain Specified Letters

        //List<string> words = new List<string>();

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter desired lenght of list");
        //int wordCount = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < wordCount; i++)
        //{
        //    Console.WriteLine(string.Empty);
        //    if (i > 0)
        //    {
        //        Console.WriteLine("Enter another word");
        //    }
        //    if (i == 0)
        //    {
        //        Console.WriteLine(string.Empty);
        //        Console.WriteLine("Enter word");
        //    }

        //    words.Add(Console.ReadLine());
        //}

        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter validation letters");

        //string letters = Console.ReadLine();

        //Methods.FilterWords(words, letters);

        #endregion

        #region CountFrequencies

        //List<string> words = new List<string>();
        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Enter desired lenght of list");
        //int wordCount = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < wordCount; i++)
        //{
        //    Console.WriteLine(string.Empty);
        //    if (i > 0)
        //    {
        //        Console.WriteLine("Enter another word");
        //    }
        //    if (i == 0)
        //    {
        //        Console.WriteLine(string.Empty);
        //        Console.WriteLine("Enter word");
        //    }

        //    words.Add(Console.ReadLine());
        //}

        //string[] wordsArray = words.ToArray();
        //Array.Sort(wordsArray);


        //Console.WriteLine(string.Empty);
        //Console.WriteLine("[{0}]", string.Join(", ", Methods.CountFrequencies(wordsArray)));

        #endregion

        #region Test

        //int i = 2, j = -1;
        //Console.WriteLine(Test(i, j));

        #endregion

        #region SplitStringRegex

        //string fullName = "FirstName MiddleName Other Names Too";
        //Methods.SplitStringRegex(fullName);
        //Console.ReadKey();

        #endregion

        #region SortColors

        //int k = 2;
        //int[] price = { 10, 22, 5, 75, 65, 80 };

        //int n = price.Length;
        //var maxProfit = Methods.GetMaxProfit(price, n, k);

        //Console.Write("Maximum profit is: " + maxProfit);

        //#endregion

        //#region SortColors

        //char[] space = new char[] { ' ' };
        //var a = Console.ReadLine();
        //var output = Methods.SortColors(a);
        //Console.WriteLine(output);

        #endregion

        #region Print Count Of Duplicate Items In Array

        //int[] arr1 = new int[] { 1, 2, 2, 2, 3 };
        //int[] arr2 = new int[] { 0, -2, -2, 5, 5, 5 };
        //int[] arr3 = new int[] { 100, 2, 101, 4 };


        //Console.WriteLine("Enter array elemenets comma separated");
        //Console.ReadLine();

        //Console.WriteLine(Methods.ArrayChallenge(Array.ConvertAll(Console.ReadLine().Split(','), int.Parse)));
        //Console.WriteLine(arr1);
        //Console.WriteLine(arr2);
        //Console.WriteLine(arr2);

        #endregion

        #region Json Cleaning

        //HttpClient client = new HttpClient();
        //string jsonString = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/json-cleaning");
        //JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
        //JsonElement cleanedJson = Methods.CleanJson(jsonDocument.RootElement);
        //string cleanedData = cleanedJson.ToString();

        //Console.WriteLine();
        //Console.WriteLine(cleanedData);

        #endregion

        #region Count Anagrams

        //Console.WriteLine("Enter a string");
        //string inputString = Console.ReadLine();
        //int anagramCount = Methods.CountAnagrams(input);
        //Console.WriteLine(string.Empty);
        //Console.WriteLine("Number of anagrams: " + anagramCount);
        //Console.WriteLine();


        #endregion

        #region Print Anangrams With Count

        //Console.WriteLine("Type a string");
        //string? stringInput = Console.ReadLine();
        //Console.WriteLine(string.Empty);
        //Methods.FindAnagrams(stringInput!);
        //Console.ReadKey();

        #endregion

        #region LengthOfLongestSubstring

        //Console.WriteLine("Type a string");
        //string? stringInput = Console.ReadLine();
        //int longestLength = Methods.LengthOfLongestSubstring(stringInput);
        //Console.WriteLine();
        //Console.WriteLine("Length of the longest substring: " + longestLength);
        //Console.ReadKey();

        #endregion

        #region LongestSubstringWithNoRepeatingCharacters

        //Console.WriteLine("Enter string");
        //string input = Console.ReadLine();
        //string longestSubstring = Methods.LongestSubstringWithNoRepeatingCharacters(input);
        //Console.WriteLine();
        //Console.WriteLine("Length of the longest substring: " + longestSubstring.Length);
        //Console.WriteLine();
        //Console.WriteLine("Longest substring without repeating characters: " + longestSubstring);
        //Console.ReadKey();

        #endregion

        #region Reverse_String

        //Console.WriteLine("Enter string");
        //string input = Console.ReadLine();  
        //string output = Methods.Reverse_String(input);
        //Console.WriteLine();
        //Console.WriteLine(output);
        //Console.ReadKey();

        #endregion

        #region ReverseArray

        //Console.WriteLine("Enter integer values (comma_sepearated)");
        //string input = Console.ReadLine();
        //string[] elements = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
        //int[] arr = new int[elements.Length];
        //for (int i = 0; i < elements.Length; i++)
        //{
        //    if (int.TryParse(elements[i], out int number))
        //    {
        //        arr[i] = number;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Invalid input: '{elements[i]}' is not a valid number.");
        //        return;
        //    }
        //}

        //Methods.ReverseArray(arr);
        //Console.WriteLine();
        //string prefix = "int[] reversedArray = " + "{";
        //string suffix = "}";

        //StringBuilder sb = new StringBuilder();
        //sb.Append(prefix);
        //sb.Append($"{string.Join(", ", arr)}");
        //sb.Append(suffix);

        //Console.WriteLine(sb.ToString());

        #endregion

        #region ReverseStringArray

        //Console.WriteLine("Enter string values (comma_sepearated)");
        //string input = Console.ReadLine();
        //string[] elements = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
        //Console.WriteLine("Original array:");
        //Console.WriteLine($"string[] arr = {string.Concat("{", string.Join(", ", elements), "}")}");

        //Methods.ReverseStringArray(elements);

        //Console.WriteLine("Reversed array:");
        //Console.WriteLine($"string[] reversedArray = {string.Concat("{", string.Join(", ", elements), "}")}");


        #endregion

        #region ArrangeNonNegativeNegativeList

        //Console.WriteLine("Enter list of integers (comma separated):");
        //string input = Console.ReadLine();

        //List<int> arr = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
        //                     .Select(int.Parse)
        //                     .ToList();

        //List<int> arrangedList = Methods.ArrangeNonNegativeNegativeList(arr);

        //Console.WriteLine();
        //Console.WriteLine("Re-Arranged List:");
        //Console.WriteLine();
        //StringBuilder sb = new StringBuilder();
        //sb.Append("List<int> re-arranged = new List<int> {");
        //sb.Append($"{string.Join(", ", arrangedList)}");
        //sb.Append("}");
        //Console.WriteLine(sb.ToString());

        #endregion

        #region LongestPalindromicSubstring

        //Console.WriteLine("Enter string value");
        //string intput = Console.ReadLine();
        //Console.WriteLine();
        //Console.WriteLine("Longest Palindromic Substring:");
        //Console.WriteLine(Methods.FindLongestPalindromicSubstring(intput));
        //Console.ReadKey();

        #endregion

        #region RemoveDuplicatesInString

        //Console.WriteLine("Enter String");
        //string input = Console.ReadLine()!.Trim().Replace(" ", "");
        //Console.WriteLine();
        //Console.WriteLine(Methods.RemoveDuplicates(input));
        //Console.ReadKey();

        #endregion

        #region SwapValues

        //Methods.SwapValues();

        #endregion

        #region DTB



        #endregion

        #region Turing



        #endregion

        #region ConvertDecimalToBinary

        //int decimalNumber = 7;
        //string binary = Methods.ConvertDecimalToBinary(decimalNumber);

        //Console.WriteLine($"Binary representation of {decimalNumber}: {binary}");
        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region ConvertIntegerToBinary

        //Console.Write("Enter an integer: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //string binary = Convert.ToString(num, 2);
        //Console.WriteLine($"The binary equivalent of {num} is {binary}");
        //Console.Read();

        #endregion

        #region VersionComparer

        Console.Write("Hello,");
        Console.WriteLine();

        while (!isValid)
        {
            Console.Write("Enter parameter 1");
            Console.WriteLine();
            var version1 = Console.ReadLine();
            if (!AppExtensions.IsValidString(version1!))
            {
                Console.Write("Input is invalid. Make sure if follows the format: '1.2.3.4");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Enter parameter 2");
                Console.WriteLine();
                var version2 = Console.ReadLine();
                if (!AppExtensions.IsValidString(version2!))
                {
                    Console.Write("Input is invalid. Make sure if follows the format: '1.2.3.4");
                    Console.WriteLine();
                }
                else
                {
                    int result = Methods.VersionCompare(version1!, version2!);
                    if (result == 0)
                    {
                        Console.WriteLine("Both versions are equal.");
                    }
                    else if (result < 0)
                    {
                        Console.WriteLine("Version 1 is less than Version 2.");
                    }
                    else
                    {
                        Console.WriteLine("Version 1 is greater than Version 2.");
                    }

                }
            }

            Console.Write("Do you want to compare more versions? (Y/N): ");
            string continueInput = Console.ReadLine()!;

            if (!string.Equals(continueInput, "Y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Thank you and goodbye! ");
                isValid = true;
            }

        }

        Console.ReadKey();






        #endregion






    }







}



#region Methods

public class DoTheyBelong
{
    public static int PointsBelong(int x1, int y1, int x2, int y2, int x3, int y3, int xp, int yp, int xq, int yq)
    {
        return 1;
    }

    static bool isInside(int x1, int y1, int x2, int y2, int x3, int y3, int xp, int yp, int xq, int yq, int x, int y)
    {
        double A = Area(x1, y1, x2, y2, x3, y3, xp, yp, xq, yq);

        /* Calculate area of triangle PBC */
        double A1 = Area(x, y, x2, y2, x3, y3, xp, yp, xq, yq);

        /* Calculate area of triangle PAC */
        double A2 = Area(x1, y1, x, y, x3, y3, xp, yp, xq, yq);

        /* Calculate area of triangle PAB */
        double A3 = Area(x1, y1, x2, y2, x, y, xp, yp, xq, yq);

        return A == A1 + A2 + A3;
    }

    //Method isto be revisited. Still not understood.
    public static double Area(int x1, int y1, int x2, int y2, int x3, int y3, int xp, int yp, int xq, int yq)
    {
        return Math.Abs((x1 * (y2 - yq) +
                         x2 * (yq - xq) +
                         x3 * (xq - yp) +
                         xp * (yp - xp) +
                         xq * (x3 - x2)) / 2.0);



    }

}

public class Methods
{
    public static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int prev = 0;
        int current = 1;

        for (int i = 2; i <= n; i++)
        {
            int temp = prev + current;
            prev = current;
            current = temp;
        }

        return current;
    }

    public static void StringwithTagsToXML()
    {
        string test = "<body><head>test header</head></body>";

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(test);

        XmlNodeList elemlist = xmlDoc.GetElementsByTagName("head");

        string result = elemlist[0]!.InnerXml;

        Console.WriteLine(result);
    }

    public static void PlainStringToXML(string stringValue)
    {

        XElement xmlElement = new XElement("OcrIsEnabled");
        xmlElement.Add(stringValue);

        Console.WriteLine(xmlElement);
    }

    public static void StoreLoss(decimal averageCostPrice, decimal averageSellingPrice, decimal amountStolen, decimal amountSpent)
    {
        if (averageSellingPrice >= averageCostPrice)
        {
            if (amountSpent < amountStolen)
            {
                if (amountSpent != averageSellingPrice)
                {
                    Console.WriteLine(string.Empty);
                    Console.WriteLine($"In this context, and for the asumptions made, the amount spent:,  {amountSpent} must be equal to the defined selling price: {averageSellingPrice}");

                    return;
                }

                decimal initialStoreLoss = amountStolen;
                decimal regainedStoreLoss = amountSpent;
                decimal remaindeStoreLoss = initialStoreLoss - regainedStoreLoss;

                decimal storeLossFromGoods = averageCostPrice;
                decimal totalStoreLoss = storeLossFromGoods + remaindeStoreLoss;

                Console.WriteLine(string.Empty);
                Console.WriteLine($"In this context, the total amount lost by the store is: {totalStoreLoss}");

                return;

            }

            Console.WriteLine(string.Empty);
            Console.WriteLine($"For correct results, available amount {amountStolen} must not be less than amount spent: {amountSpent}");

            return;
        }

        Console.WriteLine(string.Empty);
        Console.WriteLine($"For correct results, selling price: {averageSellingPrice} must be more than or equal to cost price: {averageCostPrice}");

        return;
    }

    public static bool CheckIfArrayContainsInt(int[] arrayParam, int param)
    {
        bool containsInteger = arrayParam.Contains(param);

        return containsInteger;
    }

    public static int ComputeClosestToZero(int[] temps)
    {
        if (temps.Length == 0)
        {
            return 0;
        }

        int closestToZero = 0;

        for (int i = 0; i < temps.Length; i++)
        {
            if (closestToZero == 0)
            {
                closestToZero = temps[i];
            }
            if (temps[i] > 0 && temps[i] <= Math.Abs(closestToZero))
            {
                closestToZero = temps[i];
            }
            if (temps[i] < 0 && -temps[i] < Math.Abs(closestToZero))
            {
                closestToZero = temps[i];
            }
        }

        return closestToZero;
    }

    public static int ClosestToZero(int[] temps)
    {
        if (temps.Length == 0)
        {
            return 0;
        }

        int closestToZero = temps[0];

        for (int i = 0; i < temps.Length; i++)
        {
            int number = temps[i];
            int absNumber = Math.Abs(number);
            int absClosest = Math.Abs(closestToZero);

            if (absNumber < absClosest)
            {
                closestToZero = number;
            }
            else if (absNumber == absClosest && closestToZero < 0)
            {
                closestToZero = number;
            }
        }

        return closestToZero;
    }

    public static int ReturnSmallestPositiveInteger(int[] arrayParam)
    {
        int smallestNumber = Enumerable.Range(1, 100000).Except(arrayParam).Min();
        return smallestNumber;
    }

    public static int ReturnSmallestPositiveInt(int[] arrayParam)
    {
        int rangeStart = 1, rangeEnd = 100_000;
        if (arrayParam.Length > 1_000_000)
        {
            Array.Sort(arrayParam);
            for (int i = rangeStart; 1 <= rangeEnd; i++)
            {
                int index = Array.BinarySearch(arrayParam, i);
                if (index < 0) return i;
            }
            return 0;
        }

        HashSet<int> hs = new HashSet<int>(arrayParam);
        for (int i = rangeStart; i <= rangeEnd; i++)
            if (!hs.Contains(i)) return i;
        return 0;

    }

    public static void ClosestNumbers(List<int> numbers)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> pairs = new List<int>();
        int count = numbers.Count;
        numbers.Sort();

        int minimumDiff = int.MaxValue;

        for (int i = 0; i < count - 1; i++)
        {
            minimumDiff = Math.Min(minimumDiff, Math.Abs(numbers[i] - numbers[i + 1]));
        }

        for (int i = 0; i < count - 1; i++)
        {

            if (Math.Abs(numbers[i] - numbers[i + 1]) == minimumDiff)
            {
                pairs.Add(Math.Min(numbers[i], numbers[i + 1]));
                pairs.Add(Math.Max(numbers[i], numbers[i + 1]));
                result.Add(pairs);
            }
        }

        Console.WriteLine("");

        foreach (List<int> list in result)
        {
            foreach (int listItem in list)
                Console.Write(listItem + " ");
        }

        Console.WriteLine("");

    }

    public static bool IsPalindrome(string str)
    {
        bool IsPalindrome = str.Equals(string.Join("", str.Reverse()));
        return IsPalindrome;
    }

    public static bool CheckIfStringIsPalindrome(string param)
    {
        param = param.Replace(" ", "");
        StringBuilder sb = new StringBuilder();
        for (int i = param.Length - 1; i >= 0; i--)
        {
            sb.Append(param[i]);
            if (sb.ToString() == param)
            {
                return true;
            }
        }

        return false; ;
    }

    public static int StringIsPalindrome(string param)
    {
        StringBuilder sb = new StringBuilder(param.ToLower());

        char[] charArray = param.ToCharArray();
        Array.Reverse(charArray);
        string paramReversed = new string(charArray);
        if (paramReversed == param)
        {
            return 1;
        }

        return 0;
    }

    public static void IsStringPalindrome(string param)
    {

        var flag = true;
        var n = param.Length;
        param = param.ToLower();
        var low = 0;
        var high = n - 1;
        while (high > low)
        {
            if (param[high] != param[low])
            {
                flag = false;
                break;
            }
            low++;
            high--;
        }
        if (flag)
        {
            Console.WriteLine("Yes, the given string is a palindrome");
        }
        else
        {
            Console.WriteLine("No, the given string is not a palindrome");
        }
    }

    public static void IsPalindromeString(string param)
    {
        StringBuilder sb = new StringBuilder(param.ToLower().Replace(" ", ""));
        string reversed = ReverseString(sb.ToString());
        string isPalindrome = sb.ToString() == reversed ? "Yes, the input input string is a palindrome" : "Input string is not a palindrome";

        Console.WriteLine(isPalindrome);
    }

    public static void Palindrome(string param)
    {
        bool IsPalindrome = param.ToLower().Replace(" ", "").Equals(string.Join("", param.ToLower().Replace(" ", "").Reverse())) ? true : false;

        Console.Write(IsPalindrome);
    }

    public static void CheckIfStringIsReversed(string param)
    {
        Console.WriteLine("");
    }

    public static string ReverseString(string original)
    {
        int count = original.Length / 2;
        char[] array = original.ToCharArray();

        for (int i = 0; i < count; i++)
        {
            int j = original.Length - 1 - i;
            char temp = array[i];

            array[i] = array[j];
            array[j] = array[i];
        }

        original = new string(array);

        return original;
    }

    public static string Reverse_String(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            // Swap elements at left and right indices
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // Move the left and right indices towards the center
            left++;
            right--;
        }
    }

    public static void ReverseStringArray(string[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            // Swap elements at left and right indices
            string temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // Move the left and right indices towards the center
            left++;
            right--;
        }
    }

    public static void FilterWords(List<string> words, string letters)
    {
        char[] lettersChar = letters.ToCharArray();
        List<string> resultList = new List<string>();
        string fromCharArray = "";

        foreach (string word in words)
        {
            foreach (char letter in word.ToLower())
            {
                if (lettersChar.Contains(letter))
                {
                    fromCharArray = new string(lettersChar);
                    fromCharArray = fromCharArray.Remove(fromCharArray.IndexOf(letter));
                    if (resultList.Contains(word))
                    {
                        continue;
                    }
                    resultList.Add(word);
                }

            }
        }

        string[] resultString = resultList.ToArray();
        Console.WriteLine(string.Empty);
        Console.WriteLine("Words that contain any of the validation letters are : [{0}]", string.Join(", ", resultString));
        Console.WriteLine(string.Empty);
        Array.ForEach(resultString, Console.WriteLine);

    }

    public static int[] CountFrequencies(string[] words)
    {
        List<int> resultList = new List<int>();
        List<string> countedElements = new List<string>();

        foreach (string word in words)
        {
            if (countedElements.Contains(word))
            {
                continue;
            }
            countedElements.Add(word);

            var wordCount = words.Count(w => w == word);
            resultList.Add(wordCount);
        }

        int[] result = resultList.ToArray();
        return result;
    }

    public static bool Test(int i, int j)
    {
        if (i == 1)
        {
            return true;
        }
        if (j == 1)
        {
            return true;
        }
        if ((i + j) == 1)
        {
            return true;
        }

        return false;
    }

    public static void SplitStringRegex(string fullName)
    {
        #region Original Logic

        fullName = Regex.Replace(fullName, @"[^a-zA-Z\ ]+", "");
        string[] names = Regex.Split(fullName.Replace(@"\t|\n|\r", ""), @"\s+");
        names = (from n in names select n.Trim()).ToArray();

        var firstName = names.First();
        var middleName = names.First();
        var lastName = names.Last();

        int typeId = 2, fieldId = 4, dataIndex = 0, startIndex = 1, midIndex = 2, maxIndex = 3;

        var value1 = string.Join(" ", names.Take(1).ToArray());
        var value2 = string.Join(" ", names.Skip(midIndex).Take(1).ToArray());
        var value3 = string.Join(" ", names.Skip(maxIndex).Take(names.Length - maxIndex).ToArray());

        var myVar = string.Join(" ", names.Skip(maxIndex - startIndex).Take(names.Length - (maxIndex - startIndex)).ToArray());
        var myVar2 = string.Join(" ", names.Skip(maxIndex).Take(names.Length - maxIndex).ToArray());

        #endregion

        #region Using Anonymous Object To Simulate Real Object

        var anonymousObject = new { Surname = "FooLast", GivenNames = "FooFirst FooSecond FooThird" };

        var textValue = "";
        var surName = anonymousObject.Surname;
        var givenNames = anonymousObject.GivenNames;
        textValue = string.Concat(givenNames + ' ', surName);
        textValue = Regex.Replace(textValue, @"[^a-zA-Z\ ]+", "");
        string[] newTextValue = Regex.Split(textValue.Replace(@"\t|\n|\r", ""), @"\s+");

        var fName = Regex.Replace(textValue.Split()[startIndex], @"[^a-zA-Z\ ]+", "");
        var mName = Regex.Replace(textValue.Split()[midIndex], @"[^a-zA-Z\ ]+", "");
        var lName = Regex.Replace(textValue.Split()[maxIndex], @"[^a-zA-Z\ ]+", "");

        #endregion

        #region Name Length Greater Than MaxIndex

        string myName = "Allan";
        myName = Regex.Replace(myName, @"[^a-zA-Z\ ]+", "");
        string[] newMyName = Regex.Split(myName.Replace(@"\t|\n|\r", ""), @"\s+");
        bool nameLength = textValue.Length >= 4 ? true : false;

        var stringValue = "Allan Alex Odhiambo Mwana";
        stringValue = Regex.Replace(stringValue, @"[^a-zA-Z\ ]+", "");
        string[] newstringValue = Regex.Split(stringValue.Replace(@"\t|\n|\r", ""), @"\s+");

        int maxIndex2 = 5;
        bool nameLength2 = newstringValue.Length < maxIndex2 ? true : false;

        if (nameLength2 == true)
        {
            maxIndex2 = newstringValue.Length;
        }

        var varName1 = string.Join(" ", newstringValue.Skip(dataIndex).Take(1).ToArray());
        var varName2 = string.Join(" ", newstringValue.Skip(startIndex).Take(1).ToArray());
        var varName3 = string.Join(" ", newstringValue.Skip(maxIndex2 - 2).Take(2).ToArray());
        //var varName3 = string.Join(" ", newstringValue.Skip(maxIndex2 - 2).Take(newstringValue.Length - (maxIndex2 - 1)).ToArray());

        #endregion

        #region Nested Switch And Dynamic Object

        if (typeId == 2)
        {
            switch (fieldId)
            {
                case 4:
                    {
                        dynamic dynamicObj = new ExpandoObject();
                        switch (nameLength)
                        {
                            case true:
                                dynamicObj.LastName = string.Join(" ", newTextValue.Take(1).ToArray());
                                var myFirstName = string.Concat("Other Names" + ' ', dynamicObj.LastName);
                                break;

                            default:
                                break;
                        }

                        break;
                    }
                case 5:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        #endregion

        #region Regex

        string regex = @"[^a-zA-Z\ ]+";
        regex = Regex.Unescape(regex);

        #endregion
        Console.WriteLine(string.Join(" ", names));
    }

    public static int GetMaxProfit(int[] price, int n, int k)
    {
        // table to store results of subproblems
        // profit[t][i] stores maximum profit using atmost
        // t transactions up to day i (including day i)
        int[,] profit = new int[k + 1, n + 1];

        // For day 0, you can't earn money
        // irrespective of how many times you trade
        for (int i = 0; i <= k; i++)
            profit[i, 0] = 0;

        // profit is 0 if we don't do any transaction
        // (i.e. k =0)
        for (int j = 0; j <= n; j++)
            profit[0, j] = 0;

        // fill the table in bottom-up fashion
        for (int i = 1; i <= k; i++)
        {
            for (int j = 1; j < n; j++)
            {
                int max_so_far = 0;

                for (int m = 0; m < j; m++)
                    max_so_far = Math.Max(max_so_far, price[j] -
                                   price[m] + profit[i - 1, m]);

                profit[i, j] = Math.Max(profit[i, j - 1], max_so_far);
            }
        }

        return profit[k, n - 1];
    }

    public static string SortColors(string str)
    {
        // Split the string into individual color names
        string[] colors = str.Split(' ');

        // Create a dictionary to store the original positions of the colors
        Dictionary<int, string> dict = new Dictionary<int, string>();

        // Loop through each color name to extract its position and store it in the dictionary
        foreach (string color in colors)
        {
            int position = int.Parse(color.Substring(color.Length - 1));
            string name = color.Substring(0, color.Length - 1);
            dict.Add(position, name);
        }

        // Sort the dictionary by its keys (i.e., the original positions of the colors)
        var sortedDict = dict.OrderBy(x => x.Key);

        // Create a new list to store the sorted color names
        List<string> sortedColors = new List<string>();

        // Loop through the sorted dictionary and add the color names to the list
        foreach (var kvp in sortedDict)
        {
            sortedColors.Add(kvp.Value);
        }

        // Join the sorted color names into a single string and return it
        return string.Join(" ", sortedColors);
    }

    public string RemoveConsecutiveLetters(string s)
    {
        if (s.Length < 4)
        {
            return s;
        }

        StringBuilder sb = new StringBuilder();
        int count = 1;
        char prevChar = s[0];

        for (int i = 1; i < s.Length; i++)
        {
            char currChar = s[i];

            if (currChar == prevChar)
            {
                count++;
            }
            else
            {
                if (count >= 4)
                {
                    sb.Append(prevChar, 3);
                }
                else
                {
                    sb.Append(prevChar, count);
                }

                prevChar = currChar;
                count = 1;
            }
        }

        if (count >= 4)
        {
            sb.Append(prevChar, 3);
        }
        else
        {
            sb.Append(prevChar, count);
        }

        return sb.ToString();
    }

    public static JsonElement CleanJson(JsonElement jsonElement)
    {
        if (jsonElement.ValueKind == JsonValueKind.Object)
        {
            var cleanedObject = new JsonObject();

            foreach (var property in jsonElement.EnumerateObject())
            {
                var cleanedValue = CleanJson(property.Value);

                if (!IsInvalidValue(cleanedValue))
                {
                    cleanedObject[property.Name] = cleanedValue;
                }
            }

            return cleanedObject.Count > 0 ? cleanedObject.ToJsonElement() : GetNullJsonElement();
        }
        else if (jsonElement.ValueKind == JsonValueKind.Array)
        {
            var cleanedArray = new JsonArray();

            foreach (var element in jsonElement.EnumerateArray())
            {
                var cleanedElement = CleanJson(element);

                if (!IsInvalidValue(cleanedElement))
                {
                    cleanedArray.Add(cleanedElement);
                }
            }

            return cleanedArray.Count > 0 ? cleanedArray.ToJsonElement() : GetNullJsonElement();
        }
        else
        {
            return jsonElement.Clone();
        }
    }

    public static bool IsInvalidValue(JsonElement jsonElement)
    {
        if (jsonElement.ValueKind == JsonValueKind.String)
        {
            string value = jsonElement.GetString()!;
            return string.IsNullOrEmpty(value) || value == "N/A" || value == "-";
        }

        return false;
    }

    public static JsonElement GetNullJsonElement()
    {
        return JsonDocument.Parse("null").RootElement;
    }

    public static int ArrayChallenge(int[] arr)
    {
        HashSet<int> uniqueElements = new HashSet<int>();
        int duplicateCount = 0;

        foreach (int num in arr)
        {
            if (!uniqueElements.Add(num))
            {
                duplicateCount++;
            }
        }

        return duplicateCount;
    }

    public static int ArrayChallenge2(string input)
    {
        int[] arr = Array.ConvertAll(input.Split(','), int.Parse);
        HashSet<int> uniqueElements = new HashSet<int>();
        int duplicateCount = 0;

        foreach (int num in arr)
        {
            if (!uniqueElements.Add(num))
            {
                duplicateCount++;
            }
        }

        return duplicateCount;
    }

    private static int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static int CountAnagrams(string str)
    {
        int totalCount = 0;
        int length = str.Length;

        // Create a character frequency dictionary to store the count of each character
        var charFrequency = new Dictionary<char, int>();

        // Count the frequency of each character in the string
        foreach (char c in str)
        {
            if (charFrequency.ContainsKey(c))
                charFrequency[c]++;
            else
                charFrequency[c] = 1;
        }

        // Calculate the total number of possible arrangements
        int arrangements = Factorial(length);

        // Adjust the arrangements by dividing with the factorial of each character frequency
        foreach (int frequency in charFrequency.Values)
        {
            arrangements /= Factorial(frequency);
        }

        // Subtract 1 from the arrangements to exclude the original string itself
        totalCount = arrangements - 1;

        return totalCount;
    }

    public static int CountAnagrams(string input, string target)
    {
        int count = 0;
        var freqDict = new Dictionary<char, int>();
        foreach (char c in target)
        {
            if (!freqDict.ContainsKey(c))
            {
                freqDict.Add(c, 1);
            }
            else
            {
                freqDict[c]++;
            }
        }

        for (int i = 0; i < input.Length - target.Length + 1; i++)
        {
            var subDict = new Dictionary<char, int>();
            for (int j = i; j < i + target.Length; j++)
            {
                char c = input[j];
                if (!subDict.ContainsKey(c))
                {
                    subDict.Add(c, 1);
                }
                else
                {
                    subDict[c]++;
                }
            }

            if (DictionaryEquals(freqDict, subDict))
            {
                count++;
            }
        }
        return count;
    }

    private static void GenerateAnagrams(string prefix, string remaining, Dictionary<string, string> anagramPairs)
    {
        if (remaining.Length == 0)
        {
            if (!anagramPairs.ContainsKey(prefix) && IsAnagram(prefix))
                anagramPairs.Add(prefix, prefix);
            return;
        }

        for (int i = 0; i < remaining.Length; i++)
        {
            string newPrefix = prefix + remaining[i];
            string newRemaining = remaining.Remove(i, 1);
            GenerateAnagrams(newPrefix, newRemaining, anagramPairs);
        }
    }

    private static bool IsAnagram(string str)
    {
        // Implement your anagram check logic here
        // This implementation assumes case-sensitive comparison and considers whitespace

        str = str.Trim().ToLower();

        // Convert the string to char array and sort it
        char[] charArray = str.ToCharArray();
        Array.Sort(charArray);

        // Compare the sorted string with the original string
        string sortedStr = new string(charArray);
        return string.Equals(str, sortedStr);
    }

    public static void FindAnagrams(string input)
    {
        var anagramPairs = new Dictionary<string, string>();

        GenerateAnagrams("", input, anagramPairs);

        Console.WriteLine("Anagram Pairs:");
        foreach (var pair in anagramPairs)
        {
            Console.WriteLine(pair.Key + " => " + pair.Value);
        }

        Console.WriteLine("Number of Anagram Pairs: " + anagramPairs.Count);
    }

    public static void GenerateAnagrams(string prefix, string remaining, Dictionary<char, int> charFrequency, int totalCount)
    {
        if (prefix.Length == remaining.Length)
        {
            // Exclude the original string itself
            if (prefix != remaining)
                Console.WriteLine(prefix);
            return;
        }

        foreach (char c in charFrequency.Keys)
        {
            if (charFrequency[c] > 0)
            {
                charFrequency[c]--;
                GenerateAnagrams(prefix + c, remaining, charFrequency, totalCount);
                charFrequency[c]++;
            }
        }
    }

    private static bool DictionaryEquals<TKey, TValue>(IDictionary<TKey, TValue> dict1, IDictionary<TKey, TValue> dict2)
    {
        if (dict1.Count != dict2.Count)
        {
            return false;
        }

        foreach (var pair in dict1)
        {
            if (!dict2.TryGetValue(pair.Key, out TValue? value) || !value!.Equals(pair.Value))
            {
                return false;
            }
        }

        return true;
    }

    public static int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int startIndex = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int endIndex = 0; endIndex < s.Length; endIndex++)
        {
            char currentChar = s[endIndex];
            if (charIndexMap.ContainsKey(currentChar))
            {
                startIndex = Math.Max(startIndex, charIndexMap[currentChar] + 1);
            }

            charIndexMap[currentChar] = endIndex;
            maxLength = Math.Max(maxLength, endIndex - startIndex + 1);
        }

        return maxLength;
    }

    public static string LongestSubstringWithNoRepeatingCharacters(string s)
    {
        int maxLength = 0;
        int startIndex = 0;
        int longestStartIndex = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int endIndex = 0; endIndex < s.Length; endIndex++)
        {
            char currentChar = s[endIndex];
            if (charIndexMap.ContainsKey(currentChar))
            {
                startIndex = Math.Max(startIndex, charIndexMap[currentChar] + 1);
            }

            charIndexMap[currentChar] = endIndex;
            int currentLength = endIndex - startIndex + 1;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                longestStartIndex = startIndex;
            }
        }

        return s.Substring(longestStartIndex, maxLength);
    }

    public static List<int> ArrangeNonNegativeNegativeList(List<int> arr)
    {
        List<int> arrangedList = new List<int>();

        arrangedList.AddRange(arr.Where(n => n >= 0)); // Add non-negative numbers
        arrangedList.AddRange(arr.Where(n => n < 0)); // Add negative numbers

        return arrangedList;
    }

    public static string FindLongestPalindromicSubstring(string s)
    {
        int n = s.Length;
        bool[,] dp = new bool[n, n];

        // Initialize single character substrings as palindromes
        for (int i = 0; i < n; i++)
        {
            dp[i, i] = true;
        }

        int maxLength = 1;
        int start = 0;

        // Check for palindromes of length 2 and above
        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                int j = i + len - 1;

                if (s[i] == s[j])
                {
                    // If the characters at both ends are the same,
                    // check if the substring between them is a palindrome
                    if (len == 2 || dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;

                        // Update the longest palindromic substring if necessary
                        if (len > maxLength)
                        {
                            maxLength = len;
                            start = i;
                        }
                    }
                }
            }
        }

        // Extract the longest palindromic substring from the input string
        return s.Substring(start, maxLength);

    }

    public static string RemoveDuplicates(string input)
    {
        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                sb.Append(c);
                seen.Add(c);
            }
        }

        return sb.ToString();
    }

    public static void SwapValues()
    {
        int a = 5;
        int b = 10;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a); // Output: 10
        Console.WriteLine("b = " + b); // Output: 5
        Console.ReadKey();
    }

    public static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binary = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber /= 2;
        }

        return binary;
    }

    public static int VersionCompare(string version1, string version2)
    {
        Version v1 = new Version(AppExtensions.PadVersionString(version1));
        Version v2 = new Version(AppExtensions.PadVersionString(version2));

        return v1.CompareTo(v2);
    }

    public static int VersionCompare(List<string> versions)
    {
        // Ensure there are at least two versions to compare
        if (versions.Count < 2)
        {
            throw new ArgumentException("At least two versions are required for comparison.");
        }

        // Pad each version string with zeros to match the standard format
        List<string> paddedVersions = versions.Select(AppExtensions.PadVersionString).ToList();

        // Create Version objects and compare them
        List<Version> versionObjects = paddedVersions.Select(v => new Version(v)).ToList();

        // Compare the versions and return the result
        for (int i = 1; i < versionObjects.Count; i++)
        {
            int comparisonResult = versionObjects[i - 1].CompareTo(versionObjects[i]);
            if (comparisonResult != 0)
            {
                return comparisonResult;
            }
        }

        return 0; // All versions are equal
    }


    public static int StringCompare(string version1, string version2)
    {

        if (version1 == version2)
            return 0;
        if (decimal.Parse(version1) > decimal.Parse(version2))
            return 1;
        else
            return -1;
    }

    public static int CompareStringVersions(string version1, string version2)
    {
        // Custom comparison logic here
        return string.Compare(version1, version2, StringComparison.OrdinalIgnoreCase);
    }


}





public class JsonObject : Dictionary<string, JsonElement>
{
    public JsonElement ToJsonElement()
    {
        var json = JsonSerializer.Serialize(this);
        return JsonDocument.Parse(json).RootElement;
    }
}

public class JsonArray : List<JsonElement>
{
    public JsonElement ToJsonElement()
    {
        var json = JsonSerializer.Serialize(this);
        return JsonDocument.Parse(json).RootElement;
    }
}





#endregion
