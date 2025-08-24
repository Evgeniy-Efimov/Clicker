using Engine.Services;
using Engine.Services.Interfaces;

namespace Clicker
{
    public static class DI
    {
        public static IInputService _inputService { get; private set; }
        public static IRoslynExecutor _roslynExecutor { get; private set; }
        public static IScriptService _scriptService { get; private set; }

        static DI()
        {
            _inputService = new WinInputService();
            _roslynExecutor = new RoslynExecutor();
            _scriptService = new ScriptService(_inputService);
        }
    }
}
