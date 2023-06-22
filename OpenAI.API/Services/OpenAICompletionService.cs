using OpenAI.Interfaces;
using OpenAI.ObjectModels;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels.ResponseModels;

namespace OpenAI.API.Services
{
    public class OpenAICompletionService : BackgroundService
    {
        readonly IOpenAIService _openAIService;

        public OpenAICompletionService(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.Write("::");
                CompletionCreateResponse result = await _openAIService.Completions.CreateCompletion(new CompletionCreateRequest()
                {
                    Prompt = Console.ReadLine(),
                    MaxTokens= 500,
                }, Models.TextDavinciV3 );

                Console.WriteLine(result.Choices[0].Text); 

            }
        }
    }
}
