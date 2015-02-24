# Let there be mouse

RawConsoleInput allows for the use of the mouse and keyboard in a synchronous or asynchronous manner.
Used for simple console games while teaching a friend, not to be used as a curses replacement!

````
        var _rawInput = new RawInput();

        public void HandleInput()
        {
            var input = _rawInput.MaybeGetInput();
            if (input == null) return;

            switch (input.InputType)
            {
                case InputEventType.Keyboard:
                    HandleKeyboardInput(input.KeyboardInput);
                    break;
                case InputEventType.Mouse:
                    HandleMouseInput(input.MouseInput);
                    break;
            }
        }

        public void HandleMouseInput(MouseInputEvent mouse)
        {
            if (mouse.IsLeftClick && !mouse.IsMouseMove)
            {
                _game.TryDrop(mouse.X);
            }
        }

        public void HandleKeyboardInput(KeyboardInputEvent keyboard)
        {
            if (!keyboard.KeyDown) return;

            switch (keyboard.ConsoleKeyInfo.Key)
            {
                case ConsoleKey.A:
                    _game.MoveCursorLeft();
                    break;
                case ConsoleKey.D:
                    _game.MoveCursorRight();
                    break;
                case ConsoleKey.Spacebar:
                    _game.TryDrop(_game.CursorPosition);
                    break;
            }
        }
````