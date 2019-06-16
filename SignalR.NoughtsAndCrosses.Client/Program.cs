using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using SignalR.Common.Model;
using SignalRCommon;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.NoughtsAndCrosses.Client
{
    class Program
    {
        private const string _connectionString = "https://localhost:5001/NoughtsAndCrosses";
        private static HubConnection _hubConnection;
        private static List<Table> _tables;

        static async Task Main(string[] args)
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_connectionString)
                .Build();

            var loginConfirmationHandler = _hubConnection.On<string, string>(NoughtsAndCrossesHubMethods.LoginConfirmation, AcknowledgeLogin);

            await _hubConnection.StartAsync();

            await Login();

            loginConfirmationHandler.Dispose();
            await _hubConnection.StopAsync();
        }

        private static void AcknowledgeLogin(string session, string tableInfo)
        {
            _tables = JsonConvert.DeserializeObject<List<Table>>(tableInfo);
        }

        private static async Task Login()
        {
            var username = string.Empty;
            do
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(username))
                {
                    Console.WriteLine("Username cannot be empty!");
                    continue;
                }
            } while (string.IsNullOrWhiteSpace(username));

            await _hubConnection.InvokeAsync(NoughtsAndCrossesHubMethods.Login, username);
        }
        private static void PrintMessage(string sender, string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] {sender}: {message}");
            Console.ResetColor();
        }
        
    }
}
