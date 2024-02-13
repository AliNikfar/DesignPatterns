namespace Adapter.Adapter
{
    public class ScreenPrinter
    {
        public bool PrintTextToScreen(string inputText)
        {
            Console.WriteLine(inputText);
            return true;
        }
    }
}
