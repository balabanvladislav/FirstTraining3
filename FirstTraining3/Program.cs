using System;
using System.Globalization;
namespace FirstTraining3

{
    class Program
    {
        public static object GetTypeName(string str)
        {
            int intTest;
            double doubleTest;
            char charTest;
            bool boolTest;
            DateTime dtTest;

            var style = NumberStyles.Float;
            var culture = CultureInfo.CreateSpecificCulture("eu-ES");

            if (int.TryParse(str, out intTest))
                return intTest.GetType().Name;

            else if (double.TryParse(str, out doubleTest))
                return doubleTest.GetType().Name;

            else if (double.TryParse(str, style, culture, out doubleTest))
                return doubleTest.GetType().Name;

            else if (bool.TryParse(str, out boolTest))
                return boolTest.GetType().Name;

            else if (char.TryParse(str, out charTest))
                return charTest.GetType().Name;

            else if (DateTime.TryParse(str, out dtTest))
                return dtTest.GetType().Name;

            return "String";
        }
        static void Main(string[] args)
        {
            Console.Write("Introdu ceva:");
            string input = Console.ReadLine();
            Console.WriteLine($"Tipul:{GetTypeName(input)}");
        }

    }
}
