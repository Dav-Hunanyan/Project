
static class Extension
{
    public static bool isPalindrome(this string str)
    {
       
        str=str.Trim();
        if (str.Length % 2 == 0)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    return false;
            }
            return true;
        }
        Console.WriteLine("Enter valid string:The Length must be even!!");
        return false;
    }
}
