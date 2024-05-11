﻿using ConsoleSnake.Input;

namespace ConsoleSnake
{
    public abstract class BaseGameLogic : IArrowListener
    {
        public abstract void OnArrowUp();
        public abstract void OnArrowDown();
        public abstract void OnArrowLeft();
        public abstract void OnArrowRight();
        public abstract void Update(float deltaTime);

        public void InitializeInput(ConsoleInput input)
        {
            input.Subscribe(this);
        }
    }
}