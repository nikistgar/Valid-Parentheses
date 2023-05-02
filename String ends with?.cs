public class Kata
{
    public static bool Solution(string str, string ending)
    {
        if (ending.Length > str.Length)
        {
            return false;
        }
        int j = str.Length - ending.Length;
        int diff = ending.Length;
        for (int i = 0; i < ending.Length; i++)
        {
            if (str[j] == ending[i])
            {
                diff--;
            }
            j++;
        }
        return (diff == 0);
    }
}
