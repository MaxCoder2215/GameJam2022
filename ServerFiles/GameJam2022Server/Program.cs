
using Microsoft.Data.Sqlite;
using Nancy.Hosting.Self;
static class Program
{
    public static Dictionary<string, int> PlayerIP = new Dictionary<string, int>();

    static void Main()
    {
        GivePlayerItem(1, "mimicLoses");
        TCPServer.Start();
        using (var host = new NancyHost(new Uri("http://localhost:80")))
        {
            host.Start();
            Console.WriteLine("Running on http://localhost:80");
            Console.ReadLine();
        }

        Console.WriteLine("hi");
    }

    public static void AsignPlayer(string ip, int player)
    {
        Console.WriteLine($"Player {player} asigned to {ip}");
        PlayerIP.Remove(ip);
        PlayerIP.Add(ip, player);  
    }

    public static void GivePlayerItem(int player, string itemID)
    {
        string outMessage = "";
        using (var connection = new SqliteConnection("Data Source=C:/Users/michael.hoff/Documents/unity Projects/GameJam2022/ServerFiles/GameJam2022Server/GameJam2022.db"))
        {
            connection.Open();
            Console.WriteLine(connection.Database);
            var command = connection.CreateCommand();
            command.CommandText =
            @"
        SELECT *
        FROM Events
        Where ID = $id;
    ";
            command.Parameters.AddWithValue("$id", itemID);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    outMessage += reader.GetString(0);
                }
            }
        }
        Console.WriteLine(outMessage);
        TCPServer.Messages.Enqueue($"out: {outMessage}");
    }

}