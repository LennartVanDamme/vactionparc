using System;
using System.Threading.Tasks;
using CliFx;

namespace VacationParc.Cli
{
    class Program
    {
        public static async Task<int> Main() =>
        await new CliApplicationBuilder()
            .AddCommandsFromThisAssembly()
            .Build()
            .RunAsync();
    }
}
