public static class Version2
{
    public static string StringPlusFront(int n)
    {
        string result = "";
        for (int i = n; i >= 1; i--)
        {
            result = i + (i < n ? " " : "") + result;
        }
        return result;
    }
}
