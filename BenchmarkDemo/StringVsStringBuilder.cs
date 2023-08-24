using System.Text;

namespace BenchmarkDemo;

public  class StringVsStringBuilder
{
    public  void StringDemo()
    {
        string demo = "";
        for (int i = 0; i < 100; i++)
        {
            demo += "Hello";
            demo += "Hello1";
            demo += "Hello2";
            demo += "Hello3";
        }
    }

    public  void StringBuilderDemo()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            sb.Append("Hello");
            sb.Append("Hello");
            sb.Append("Hello");
            sb.Append("Hello");
        }
        var s = sb.ToString();
    }
}
