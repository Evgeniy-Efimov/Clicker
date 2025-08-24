using Engine.Services.Interfaces;

namespace Engine.Services
{
    public class ScriptService : IScriptService
    {
        private readonly IInputService _inputService;
        private CancellationTokenSource _cancellationTokenSource;

        public ScriptService(IInputService inputService)
        {
            _inputService = inputService;
        }

        public CancellationTokenSource CreateCancellationTokenSource()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            return _cancellationTokenSource;
        }

        public void hold(string key)
        {
            _inputService.HoldButton(key);
        }

        public void hold_left()
        {
            _inputService.HoldLeftMouseButton();
        }

        public void hold_right()
        {
            _inputService.HoldRightMouseButton();
        }

        public void click(int x, int y)
        {
            left_click(x, y);
        }

        public void left_click(int x, int y)
        {
            _inputService.LeftClick(x, y);
        }

        public void mouse_move(int x, int y)
        {
            _inputService.MoveMouse(x, y);
        }

        public void mouse_scroll(int delta)
        {
            _inputService.ScrollMouse(delta);
        }

        public void press(params string[] keys)
        {
            _inputService.PressButtons(keys);
        }

        public void release(string key)
        {
            _inputService.ReleaseButton(key);
        }

        public void release_left()
        {
            _inputService.ReleaseLeftMouseButton();
        }

        public void release_right()
        {
            _inputService.ReleaseRightMouseButton();
        }

        public void right_click(int x, int y)
        {
            _inputService.RightClick(x, y);
        }

        public async Task ms(int milliseconds)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(milliseconds), _cancellationTokenSource.Token);
        }
    }
}
