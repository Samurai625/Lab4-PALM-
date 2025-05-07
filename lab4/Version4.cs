using System.Text;

public static class Version4
{
    public static string StringBuilderInsert(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = n; i >= 1; i--)
        {
            sb.Insert(0, i + (i < n ? " " : ""));
        }
        return sb.ToString();
    }
}
