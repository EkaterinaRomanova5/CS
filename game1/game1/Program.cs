using Microsoft.Extensions.DependencyInjection;
using MyLib;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
        .AddSingleton<InputService, ConsoleInputService>()
        .AddSingleton<NumberGenerator, RandomNumberGenerator>()
        .AddSingleton<OutputService, ConsoleOutputService>()
        .AddSingleton<Game>()
        .BuildServiceProvider();

        var game = serviceProvider.GetService<Game>();
        game.Start();

    }
}