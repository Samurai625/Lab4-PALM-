public static class Version1
{
    public static string StringPlusEqual(int n)
    {
        string result = "";
        for (int i = 1; i <= n; i++)
        {
            result += i + (i < n ? " " : "");
        }
        return result;
    }
}
