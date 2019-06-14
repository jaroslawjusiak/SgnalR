using Microsoft.AspNetCore.SignalR.Client;
using SignalRCommon;
using System;
using System.Threading.Tasks;

namespace SignalRTestClient
{
    class Program
    {
        private const string _connectionString = "https://localhost:5001/testhub";
        static HubConnection _hubConnection;

        static async Task Main(string[] args)
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_connectionString)
                .Build();

            var testHubMethodHandler = _hubConnection.On<string, string>(TestHubMethods.TestMessage, PrintMessage);
        }

        private static async Task Listener()
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();
            string input;

            do
            {
                input = Console.ReadLine();
                ClearCurrentConsoleLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                await _hubConnection.InvokeAsync(TestHubMethods.TestMessage, username, input);

            } while (input?.Equals("exit") != true);
        }


        private static void PrintMessage(string sender, string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] {sender}: {message}");
            Console.ResetColor();
        }

        private static void ClearCurrentConsoleLine()
        {
            var currentLineCursor = Console.CursorTop - 1;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
