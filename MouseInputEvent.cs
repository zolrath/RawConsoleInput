namespace RawConsoleInput
{
    public class MouseInputEvent
    {
        public int X;
        public int Y;
        public int ButtonState;
        public int ControlKeyState;
        public int EventFlags;

        public MouseInputEvent(ushort x, ushort y, int buttonState, int controlKeyState, int eventFlags)
        {
            X = x;
            Y = y;
            ButtonState = buttonState;
            ControlKeyState = controlKeyState;
            EventFlags = eventFlags;
        }

        public bool IsLeftClick => 1 << 0 == (ButtonState & 1 << 0);
        public bool IsRightClick => 1 << 1 == (ButtonState & 1 << 1);
        public bool IsMiddleClick => 1 << 2 == (ButtonState & 1 << 2);
        public bool IsShifted => 1 << 0 == (ControlKeyState & 1 << 0);
        public bool IsCtrled => 1 << 1 == (ControlKeyState & 1 << 1);
        public bool IsAlted => 1 << 2 == (ControlKeyState & 1 << 2);
        public bool IsWinKeyed => 1 << 3 == (ControlKeyState & 1 << 3);
        public bool IsDoubleClick => 1 << 1 == (EventFlags & 1 << 1);
        public bool IsMouseDown => 0 == EventFlags;
        public bool IsMouseMove => 1 == (EventFlags & 1);

        public bool IsMouseWheelUp => (1 << 2 == (EventFlags & 1 << 2)) && (ButtonState > 0);
        public bool IsMouseWheelDown => (1 << 2 == (EventFlags & 1 << 2)) && (ButtonState < 0);
        public bool IsMouseWheelLeft => (1 << 3 == (EventFlags & 1 << 3)) && (ButtonState < 0);
        public bool IsMouseWheelRight => (1 << 3 == (EventFlags & 1 << 3)) && (ButtonState > 0);
    }
}