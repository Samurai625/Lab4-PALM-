using System.Text;

public static class Version3
{
    public static string StringBuilderAppend(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            sb.Append(i);
            if (i < n) sb.Append(' ');
        }
        return sb.ToString();
    }
}
