using System;

using System.Text;
namespace StringAndStringBuilder
{
    //  This program demo. how to use StringBuilder class
    class StringBuilderDemo
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder("This is test string");
            Console.WriteLine("MaxCapacity of this string is {0}",stringBuilder.MaxCapacity);
            Console.WriteLine("Length of this string is:{0}",stringBuilder.Length);
            Console.WriteLine("Char at index 0 is:{0}",stringBuilder[0]);
            stringBuilder.Append(" to use StringBuilders");
            Console.WriteLine("After appending new string {0}",stringBuilder);
            stringBuilder.Insert(5, "hello");
            Console.WriteLine("After inserting new string {0}", stringBuilder);
            StringBuilder stringBuilder1 = stringBuilder.Replace("test", "demo");
            Console.WriteLine("After replacing demo with hello {0}",stringBuilder1);
            Console.ReadLine();
        }
    }
}
