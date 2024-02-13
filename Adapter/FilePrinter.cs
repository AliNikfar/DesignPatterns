namespace Adapter.Adapter
{
    public class FilePrinter : IPrinter
    {
        public void Print(string input)
        {
            System.IO.File.WriteAllText(@"d:\output.txt", input);
        }
    }
}
