namespace Adapter.Adapter
{
    // Object Adapter
    public class ObjectAdapter : IPrinter
    {

        private readonly ScreenPrinter _screenPrinter;

        public ObjectAdapter()
        {
            _screenPrinter = new ScreenPrinter();
        }

        public void Print(string input)
        {
            _screenPrinter.PrintTextToScreen(input);
        }
    }


    // inheritance Adapter
    public class InheriteAdapter : ScreenPrinter, IPrinter
    {
        public void Print(string input)
        {
            this.PrintTextToScreen(input);
        }
    }
}
