using Microsoft.AspNetCore.SignalR.Client;
namespace ChatClient.Pages
{
    public partial class Chat
    {
        private HubConnection? hubConnection;// SignalR Hub connection
        private string user = string.Empty;
        private string message = string.Empty;
        private List<string> messages = new();

        protected override async Task OnInitializedAsync()
        {// Initialize the HubConnection
            hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5259/chathub")
                .WithAutomaticReconnect()
                .Build();
            // Set up the ReceiveMessage handler
            hubConnection.On<string, string>("ReceiveMessage", (user, msg) =>
            {
                messages.Add($"{user}: {msg}");
                InvokeAsync(StateHasChanged);
            });
            // Start the connection
            await hubConnection.StartAsync();
        }

        private async Task Send()
        {
            if (hubConnection is not null)
            {
                // Send the message to the server
                await hubConnection.SendAsync("SendMessage", user, message);
                message = string.Empty;
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (hubConnection is not null)
            {
                await hubConnection.DisposeAsync();
            }
        }
    }
}
