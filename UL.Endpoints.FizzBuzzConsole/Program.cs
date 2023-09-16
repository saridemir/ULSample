using Microsoft.Extensions.Hosting; // Requires NuGet package
using Microsoft.Extensions.DependencyInjection;
using UL.Common.Services.Implementations;
using UL.Common.Services.Interfaces;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => { services.AddTransient<IFizzBuzzService, FizzBuzzService>(); })
    .Build();

var fb = host.Services.GetRequiredService<IFizzBuzzService>();

fb.WriteFizzBuzz();