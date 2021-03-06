using System;
using jsonManipulation;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String _pathJson = "C:\\Users\\lewan\\source\\repos\\jsonHandler\\testApp\\test.json";
            jsonHandler myHandler = new jsonHandler(_pathJson);
            Console.WriteLine(myHandler.getJsonPath);
            Console.WriteLine("------------------------------------");
            Console.WriteLine(myHandler.readJsonFile());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(myHandler.replaceAttributeNameInJson("test", "ValeurDeTest"));
            myHandler.exportJson("C:\\Users\\lewan\\source\\repos\\jsonHandler\\testApp", "returned");
        }
    }
}
