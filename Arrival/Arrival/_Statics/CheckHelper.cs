using System.Globalization;
using System.Linq;

namespace Arrival._Statics
{
    public class CheckHelper
    {
        public static bool Modulus11(string cpr) 
        {
            if(cpr.IsNullOrEmpty())
                return false;

            //if(!IsCPR(cpr))
            //    return false;

            int[] weights = new int[] { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

            int count = 0;
            int res = 0;
            foreach(char _c in cpr)
            {
                if (_c == '-')
                    continue;

                int _a = int.Parse("" + _c);
                int _b = weights[count];
                res += _a * _b;
                count++;
            }

            return res % 11 == 0;
        }

        public static string RemoveCharacters(string cpr)
        {
            char[] oks = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-' };
            string res = "";
            foreach (char _c in cpr)
            {
                if (!oks.Contains(_c))
                    continue;
                res += _c;
            }

            return res;
        }

        public static bool IsEven(string cpr)
        {
            /*
             * could have been done with a modulus
             * */

            if (cpr.IsNullOrEmpty())
                return false;

            string[] even = new string[] { "0", "2", "4", "6", "8" };

            string last = cpr.Substring(cpr.Length - 1, 1);

            return even.Contains(last);
        }

        public static bool IsDash(string cpr)
        {
            if (cpr.IsNullOrEmpty())
                return false;

            string last = cpr.Substring(cpr.Length - 1, 1);

            return last == "-";
        }

        public static bool NeedsDash(string cpr)
        {
            if (cpr.IsNull())
                return false;

            return cpr.Count() == 6;
        }

        public static bool CheckDash(string cpr) 
        {
            bool ok = true;

            if (cpr.Where(x=>"" + x == "-").Count() > 1)
                ok &= false;

            if (cpr.Length != 7 && IsDash(cpr))
                ok &= false;

            if (!(cpr.IndexOf('-') == 6 || cpr.IndexOf('-') == -1))
                ok &= false;

            return ok;
        }

        public static bool FirstPart(string cpr)
        {
            if (cpr.IsNullOrEmpty())
                return false;

            string first = "abc";
            if (cpr.Where(x => "" + x == "-").Count() == 0)
                first = cpr;
            if (cpr.Where(x => "" + x == "-").Count() == 1)
                first = cpr.Split('-')[0];
            
            int res;
            bool ok = int.TryParse(first, out res);

            return ok;
        }

        public static bool SecondPart(string cpr)
        {
            if (cpr.IsNullOrEmpty())
                return false;

            string second = FirstPart(cpr) ? "-1" : "abc";
            if (cpr.Where(x => "" + x == "-").Count() == 1)
                second = cpr.Split('-')[1];

            int res;
            bool ok = int.TryParse(second, out res);

            return ok;
        }

        public static bool IsCPR(string cpr)
        {
            if (cpr.IsNullOrEmpty())
                return false;

            bool ok = true;

            if (!cpr.Contains("-"))
                ok &= false;

            if (cpr.Length != 11)
                ok &= false;

            if (!FirstPart(cpr) || !SecondPart(cpr))
                ok &= false;

            if (!Modulus11(cpr))
                ok &= false;

            return ok;
        }

    }
}
