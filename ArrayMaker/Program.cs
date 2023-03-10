using System.Text;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            foreach (string txt in File.ReadAllLines("TextFile1.txt"))
            {
                sb.Append("\"" + txt + "\"");
                if(File.ReadAllLines("TextFile1.txt").Last() != txt)
                {
                    sb.Append(",");
                }
            }
            sb.Append("};");
            File.WriteAllText("Result.txt", sb.ToString());
        }
    }
}
