namespace ConsoleSnake.Snake
{
    public enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right,
    }
    
    public struct Cell
    {
        public float X { get; }
        public float Y { get; }

        public Cell(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
    
    public sealed class SnakeGameplayState : BaseGameState
    {
        private List<Cell> _snakeBody = new();
        private MoveDirection _direction;
        private float _timeToMove;
        private const int TimeConstant = 5;
        
        public override void Update(float deltaTime)
        {
            _timeToMove -= deltaTime;

            if (_timeToMove > 0)
                return;

            _timeToMove = 1f / TimeConstant;
            
            var head = _snakeBody[0];
            var nextCell = ShiftTo(head, _direction);
            
            _snakeBody.RemoveAt(_snakeBody.Count - 1);
            _snakeBody.Insert(0, nextCell);
            
            Console.WriteLine($"{_snakeBody[0].X} {_snakeBody[0].Y}");
        }

        public override void Reset()
        {
            _snakeBody.Clear();
            _direction = MoveDirection.Right;
            _snakeBody.Add(new Cell(0f,0f));
            _timeToMove = 0f;
        }

        public void SetDirection(MoveDirection direction)
        {
            _direction = direction;
        }

        public Cell ShiftTo(Cell head, MoveDirection direction)
        {
            switch (direction)
            {
                case MoveDirection.Up:
                    return new Cell(head.X, head.Y + 1);
                case MoveDirection.Down:
                    return new Cell(head.X, head.Y - 1);
                case MoveDirection.Left:
                    return new Cell(head.X - 1, head.Y);
                case MoveDirection.Right:
                    return new Cell(head.X + 1, head.Y);
                default:
                    return head;
            }
        }
    }
}