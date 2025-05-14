using System.Text;

public static class Version4
{
    public static string StringBuilderInsert(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = n; i >= 1; i--)
        {
            if(i<n)
                sb.Insert(0, i + " ");
            else
                sb.Insert(0, i);
        }
        return sb.ToString();
    }
}
