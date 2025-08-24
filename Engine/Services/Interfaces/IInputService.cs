namespace Engine.Services.Interfaces
{
    public interface IInputService
    {
        (int x, int y) GetCursorPosition();
        void LeftClick();
        void LeftClick(int x, int y);
        void HoldLeftMouseButton();
        void HoldLeftMouseButton(int x, int y);
        void ReleaseLeftMouseButton();
        void RightClick();
        void RightClick(int x, int y);
        void HoldRightMouseButton();
        void HoldRightMouseButton(int x, int y);
        void ReleaseRightMouseButton();
        void MoveMouse(int x, int y);
        void ScrollMouse(int delta);
        void PressButton(string buttonName);
        void PressButtons(params string[] buttonNames);
        void HoldButton(string buttonName);
        void ReleaseButton(string buttonName);
    }
}
