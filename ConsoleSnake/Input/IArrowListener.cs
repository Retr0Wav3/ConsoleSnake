namespace ConsoleSnake.Input
{
    public interface IArrowListener
    {
        abstract void OnArrowUp();
        abstract void OnArrowDown();
        abstract void OnArrowLeft();
        abstract void OnArrowRight();
    }
}