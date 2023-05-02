public class Kata
{
    public static bool ValidParentheses(string str)
    {
        string prev = "";
        while (str.Length != prev.Length)
        {
            prev = str;
            str = str.Replace("()", string.Empty);
        }
        return (str.Length == 0);
    }
}