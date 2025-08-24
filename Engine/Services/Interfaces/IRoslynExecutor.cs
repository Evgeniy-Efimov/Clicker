namespace Engine.Services.Interfaces
{
    public interface IRoslynExecutor
    {
        Task<object> ExecuteAsync(string code, object globals, CancellationToken cancellationToken = default);
    }
}
