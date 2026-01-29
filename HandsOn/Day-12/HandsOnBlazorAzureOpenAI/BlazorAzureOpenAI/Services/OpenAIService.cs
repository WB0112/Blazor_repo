using Azure;
using Azure.AI.OpenAI;
using OpenAI;
using OpenAI.Chat;
namespace BlazorAzureOpenAI.Services
{
    public class OpenAIService
    {
        private readonly OpenAIClient _client;
        private readonly string _chatDeployment;
        private readonly string _embeddingDeployment;

        public OpenAIService(IConfiguration config)
        {
            _client = new OpenAIClient(
                new Uri(config["AzureOpenAI:Endpoint"]),
                new AzureKeyCredential(config["AzureOpenAI:ApiKey"])
            );

            _chatDeployment = config["AzureOpenAI:ChatDeployment"];
            _embeddingDeployment = config["AzureOpenAI:EmbeddingDeployment"];
        }

        // 1️⃣ Smart Text / Paste
        public async Task<string> ImproveTextAsync(string input)
        {
            var options = new ChatCompletionsOptions()
            {
                Messages =
            {
                new ChatMessage(ChatRole.System,
                    "You are a professional assistant. Improve clarity and structure."),
                new ChatMessage(ChatRole.User, input)
            }
            };

            var response = await _client.GetChatCompletionsAsync(
                _chatDeployment, options);

            return response.Value.Choices[0].Message.Content;
        }

        // 2️⃣ Chatbot
        public async Task<string> ChatAsync(List<ChatMessage> history, string userInput)
        {
            history.Add(new ChatMessage(ChatRole.User, userInput));

            var options = new ChatCompletionsOptions();
            history.ForEach(m => options.Messages.Add(m));

            var response = await _client.GetChatCompletionsAsync(
                _chatDeployment, options);

            var reply = response.Value.Choices[0].Message.Content;
            history.Add(new ChatMessage(ChatRole.Assistant, reply));

            return reply;
        }

        // 3️⃣ Embeddings
        public async Task<float[]> CreateEmbeddingAsync(string text)
        {
            var embedding = await _client.GetEmbeddingsAsync(
                _embeddingDeployment,
                new EmbeddingsOptions(text));

            return embedding.Value.Data[0].Embedding.ToArray();
        }
    }
}
