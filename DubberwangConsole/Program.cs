using DubberwangCore;
using DubberwangInterfaces.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pastel;

// Dependency injection could be considered overkill here
using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddSingleton<ILotteryGenerator, LotteryGenerator>();
    })
    // For this task we aren't interested in logging
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders();
    })
    .UseConsoleLifetime()
    .Build();

DubberLottery(host.Services);

await host.RunAsync();

// Static method to handle Lottery logic looping
static void DubberLottery(IServiceProvider services)
{
    Console.WriteLine("Welcome to Dubberwang!");
    
    ILotteryGenerator generator = services.GetService<ILotteryGenerator>() ?? throw new InvalidOperationException();
    
    // Lazy, needs proper method
    while (true)
    {
        ExecuteNewLottery(generator);
        Console.WriteLine("Want to go again? (Or press CTRL+C to quit!)");
        Console.ReadKey();
    }
}

// Static method to handle execution of new Lottery results
static void ExecuteNewLottery(ILotteryGenerator generator)
{
    List<ILotteryBall> lotteryBalls = generator.GetNewLotteryBalls(6);
    // Sadly the console does not support Hex colors by default, so we are using an external library here
    string result = String.Join(", ", lotteryBalls.Select(x => x.Value.ToString().Pastel(x.HexColor)));
    Console.WriteLine(result);
}
