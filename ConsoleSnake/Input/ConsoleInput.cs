namespace ConsoleSnake.Input
{
    public sealed class ConsoleInput
    {
        private readonly HashSet<IArrowListener> _arrowListeners = new();

        public void Update()
        {
            while (Console.KeyAvailable)
            {
                var input = Console.ReadKey();

                foreach (var listener in _arrowListeners)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.W or ConsoleKey.UpArrow:
                            listener.OnArrowUp();
                            break;
                        case ConsoleKey.S or ConsoleKey.DownArrow:
                            listener.OnArrowDown();
                            break;
                        case ConsoleKey.A or ConsoleKey.LeftArrow:
                            listener.OnArrowLeft();
                            break;
                        case ConsoleKey.D or ConsoleKey.RightArrow:
                            listener.OnArrowRight();
                            break;
                    }
                }
            }
        }

        public void Subscribe(IArrowListener listener)
        {
            _arrowListeners.Add(listener);
        }
    }
}