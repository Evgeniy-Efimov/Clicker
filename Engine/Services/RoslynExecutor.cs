using Engine.Services.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Engine.Services
{
    public class RoslynExecutor : IRoslynExecutor
    {
        public async Task<object> ExecuteAsync(string code, object globals, CancellationToken cancellationToken = default)
        {
            var options = ScriptOptions.Default
                .AddImports("System", "System.IO", "System.Linq")
                .AddReferences(
                    typeof(object).Assembly,
                    typeof(Enumerable).Assembly
                );

            try
            {
                return await CSharpScript.EvaluateAsync(code, options, globals, cancellationToken: cancellationToken);
            }
            catch (CompilationErrorException e)
            {
                throw new Exception($"Compilation error: {string.Join("\n", e.Diagnostics)}");
            }
        }
    }
}
