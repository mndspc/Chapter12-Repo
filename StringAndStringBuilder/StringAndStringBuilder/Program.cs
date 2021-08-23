using System;


namespace StringAndStringBuilder
{
    class Program
    {
        //  This program demo. how to use String
        static void Main(string[] args)
        {
            string myString = "This is test string";
            //myString += " How are you?";
            //  Indexer for string
            Console.WriteLine("char at index 1 is {0}", myString[1]);
            //  Length property
            Console.WriteLine("Length is {0}",myString.Length);
            //  Contains() method to check weither string is present or not
            string search = "test";
           if(myString.Contains(search.ToLowerInvariant()))
            {
                Console.WriteLine("test is present");
            }
            else
            {
                Console.WriteLine("test is not present");
            }
            //  StartWith() to check weither string starts with given letters
            string startWith = "this";
          if(myString.ToLowerInvariant().StartsWith(startWith))
            {
                Console.WriteLine("string starts with this");
            }
            //  EndsWith() to check weither string ends with given letters
         if(myString.ToLowerInvariant().EndsWith("string"))
            {
                Console.WriteLine("string ends with string");
            }
            // To extract new string from given string
            string substring = myString.Substring(8, 4);
            Console.WriteLine("sub string is {0}",substring);
            //  To compare strings
            string myString1 = "This is test string";
           int result= string.Compare(myString, myString1, true);
            Console.WriteLine(result==0? "both strings are equal":"both strings are not equal");
            Console.ReadLine();
        }
    }
}
