using UL.Core.ULMath;
using Microsoft.Extensions.Hosting; // Requires NuGet package
using Microsoft.Extensions.DependencyInjection;
using UL.Common.Services.Implementations;
using UL.Common.Services.Interfaces;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => { services.AddTransient<IFactorialService, FactorialService>(); })
    .Build();

var fs = host.Services.GetRequiredService<IFactorialService>();

Console.WriteLine("Enter number of factorial");
fs.FindFactorial(Console.ReadLine());