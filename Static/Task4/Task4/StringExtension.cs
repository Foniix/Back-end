namespace Task4
{
    static class StringExtension
    {
        public static string MySubstring(this string str, int beg, int len)
        {
            var res = new char[len];
            for (var i = 0; i < len; i++)
                res[i] = str[i + beg];
            return new string(res);
        }
        public static int MyIndexOf(this string str, string value)
        {
            for (var i = 0; i < str.Length - value.Length + 1; i++)
                if (str.MySubstring(i, value.Length) == value)
                    return i;
            return -1;
        }
        public static string MyReplace(this string str, string oldValue, string newValue)
        {
            while (str.MyIndexOf(oldValue) >= 0)
            {
                var i = str.MyIndexOf(oldValue);
                str = str.Remove(i, oldValue.Length);
                str = str.Insert(i, newValue);
            }
            return str;
        }
    }
}
