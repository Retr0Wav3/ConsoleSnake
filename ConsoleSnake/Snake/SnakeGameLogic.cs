namespace ConsoleSnake.Snake
{
    public class SnakeGameLogic : BaseGameLogic
    {
        private SnakeGameplayState _gameplayState = new();
    
        public override void OnArrowUp()
        {
            _gameplayState.SetDirection(MoveDirection.Up);
        }

        public override void OnArrowDown()
        {
            _gameplayState.SetDirection(MoveDirection.Down);
        }

        public override void OnArrowLeft()
        {
            _gameplayState.SetDirection(MoveDirection.Left);
        }

        public override void OnArrowRight()
        {
            _gameplayState.SetDirection(MoveDirection.Right);
        }

        public override void Update(float deltaTime)
        {
            _gameplayState.Update(deltaTime);
        }

        public void GotoGameplay()
        {
            _gameplayState.Reset();
        }
    }
}