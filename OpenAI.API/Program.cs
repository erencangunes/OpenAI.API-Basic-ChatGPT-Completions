using Microsoft.Extensions.DependencyInjection;
using OpenAI.API;
using OpenAI.API.Services;
using OpenAI.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "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");
        services.AddHostedService<OpenAICompletionService>();

    })
    .Build();

await host.RunAsync();
