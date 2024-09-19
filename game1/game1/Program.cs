using Microsoft.Extensions.DependencyInjection;
using MyLib;

class Program //основной класс для запуска приложения
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection() //регистрация зависимостей и их разрешения
        .AddSingleton<InputService, ConsoleInputService>()
        .AddSingleton<NumberGenerator, RandomNumberGenerator>()
        .AddSingleton<OutputService, ConsoleOutputService>()
        .AddSingleton<Game>()
        .BuildServiceProvider();

        var game = serviceProvider.GetService<Game>();
        game.Start();

    }
}