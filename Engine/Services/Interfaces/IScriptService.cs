namespace Engine.Services.Interfaces
{
    public interface IScriptService
    {
        CancellationTokenSource CreateCancellationTokenSource();
        void click(int x, int y);
        void left_click(int x, int y);
        void right_click(int x, int y);
        void mouse_move(int x, int y);
        void hold_left();
        void release_left();
        void hold_right();
        void release_right();
        void mouse_scroll(int delta);
        void press(params string[] keys);
        void hold(string key);
        void release(string key);
        Task ms(int milliseconds);
    }
}
