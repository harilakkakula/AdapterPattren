using System;

namespace AdapterPattren
{
    class Program
    {
        static void Main(string[] args)
        {
            ITranslater manager = new Translate("telugu");
            string values= manager.Transalate("Name");
            Console.WriteLine(values);
            Console.ReadLine();
        }
    }
}
