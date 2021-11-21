using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StringManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            //StringConversion();
            //StringAsArray();
            //EscapeString();
            //AppendingStrings();
            //InterpolationAndLiteral();
            //StringBuilderDemo();
            //WorkingWithArrays();
            //PadAndTrim();
            SearchingStrings();
        }


        private static void StringConversion()
        {
            string testString = "This is the FBI Calling!";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;
            string result;

            result = englishTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);
        }
        private static void StringAsArray()
        {
            string testString = "Timothy";

            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);
            }
        }
        private static void EscapeString()
        {
            string results;

            results = "This is my \"test\" solution.";
            Console.WriteLine(results);

            results = "C:\\Demo\\Test.txt";
            Console.WriteLine(results);

            results = @"C:\Demo\Test.txt";
            Console.WriteLine(results);
        }
        private static void AppendingStrings()
        {
            string firstName = "Mochael";
            string lastName = "Walka";
            string results;

            results = firstName + ", my name is " + firstName + " " + lastName;
            Console.WriteLine(results);

            results = string.Format("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(results);

            results = $"{firstName}, my name is {firstName} {lastName}";
            Console.WriteLine(results);
        }
        private static void InterpolationAndLiteral()
        {
            string testString = "Mike Walka";
            string results = $@"C:\Repos\{testString}\{"\""}Test{"\""}.txt";

            Console.WriteLine(results);
        }
        private static void StringBuilderDemo()
        {
            Stopwatch reqularStopwatch = new Stopwatch();
            reqularStopwatch.Start();

            string test = "";

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }

            reqularStopwatch.Stop();
            Console.WriteLine($"Regular Stopwatch: {reqularStopwatch.ElapsedMilliseconds }ms");

            Stopwatch builderStopwatch = new Stopwatch();
            builderStopwatch.Start();

            StringBuilder sb = new();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }

            reqularStopwatch.Stop();
            Console.WriteLine($"String Builder Stopwatch: {builderStopwatch.ElapsedMilliseconds }ms");
        }
        private static void WorkingWithArrays()
        {
            int[] ages = new int[] { 6, 7, 8, 3, 5 };
            string results;
            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(",",ages);
            Console.WriteLine(results);

            Console.WriteLine();

            string testString = "Mike,John,Tim,Todd,Bob,Sally";
            string[] resultsArray = testString.Split(',');
            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            Console.WriteLine();

            testString = "Mike, John, Tim, Todd, Bob, Sally";
            resultsArray = testString.Split(", ");
            Array.ForEach(resultsArray, x => Console.WriteLine(x));
        }
        private static void PadAndTrim()
        {
            string testString = "     Hello World     ";
            string results;

            results = testString.TrimStart();
            Console.WriteLine($"'{results}'");

            results = testString.TrimEnd();
            Console.WriteLine($"'{results}'");

            results = testString.Trim();
            Console.WriteLine($"'{results}'");

            testString = "1.15";
            results = testString.PadLeft(10, '*');
            Console.WriteLine(results);

            results = testString.PadRight(10, '0');
            Console.WriteLine(results);
        }
        private static void SearchingStrings()
        {
            string testString = "This is a test of the search. Let's see how its testing works out.";
            bool resultsBoolean;
            int resultsInt;

            resultsBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Start with \"This is\": {resultsBoolean}");

            resultsBoolean = testString.StartsWith("this is");
            Console.WriteLine($"Start with \"This is\": {resultsBoolean}");

            resultsBoolean = testString.EndsWith("works out.");
            Console.WriteLine($"Start with \"works out.\": {resultsBoolean}");

            resultsBoolean = testString.Contains("test");
            Console.WriteLine($"Start with \"test.\": {resultsBoolean}");

            resultsBoolean = testString.Contains("tests");
            Console.WriteLine($"Start with \"tests.\": {resultsBoolean}");

            resultsInt = testString.IndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");

            resultsInt = testString.IndexOf("test", 11);
            Console.WriteLine($"Index of \"test\" after character 10: {resultsInt}");

            resultsInt = testString.IndexOf("test", 49);
            Console.WriteLine($"Index of \"test\" after character 49: {resultsInt}");

            resultsInt = testString.LastIndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 48);
            Console.WriteLine($"Index of \"test\" after character 48: {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 10);
            Console.WriteLine($"Index of \"test\" after character 10: {resultsInt}");

        }
        private static void OrderingStrings()
        {

        }
        private static void CompareToHelper(string testA, string? testB)
        {

        }
    }
}
