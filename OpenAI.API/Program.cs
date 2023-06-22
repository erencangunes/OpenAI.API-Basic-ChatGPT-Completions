using Microsoft.Extensions.DependencyInjection;
using OpenAI.API;
using OpenAI.API.Services;
using OpenAI.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "MY_OPEN_AI_API_KEY");
        services.AddHostedService<OpenAICompletionService>();

    })
    .Build();

await host.RunAsync();
