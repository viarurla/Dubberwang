using DubberwangCore;
using DubberwangInterfaces.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pastel;


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

static void ExecuteNewLottery(ILotteryGenerator generator)
{
    List<ILotteryBall> lotteryBalls = generator.GetNewLotteryBalls(6);
    string result = String.Join(", ", lotteryBalls.Select(x => x.Value.ToString().Pastel(x.HexColor)));
    Console.WriteLine(result);
}
