using CodeKata2;
using System;

namespace CodeKata2
{
    public class ValiISBN
    {
        public bool ValiISB(string isbn)
        {
            string IsbnNum = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-9]", "");
            if (IsbnNum.Length != 10)
            {
                return false;
            }

            int Result = 0;

            for (int i = 0; i < IsbnNum.Length; i++)
            {
                int Numb = -1;
                Numb = (int)char.GetNumericValue(IsbnNum[i]);
                Result = Result + Numb * (10 - i);
            }

            return ((Result % 11) == 0);
        }

        public bool Valid13Dig(string isbn)
        {
            string IsbnNum = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-12]", "");
            if (IsbnNum.Length != 13)
            {
                return false;
            }

            int Result = 0;

            for (int i = 0; i < IsbnNum.Length; i++)
            {
                int Numb = -1;
                Numb = (int)char.GetNumericValue(IsbnNum[i]);
                Result = Result + Numb * (10 - i);
            }

            return ((Result % 11) == 0);

        }



    }


}
class Code
{
    static void Main(string[] args)
    {
        ValiISBN obj = new ValiISBN();
        //Console.WriteLine("Ingrese el numero: ");

        string isbn = "0716703440";

        if (obj.ValiISB(isbn))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");

        string iisbnn = "9780716703440";

        if (obj.Valid13Dig(iisbnn))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");

    }
}

