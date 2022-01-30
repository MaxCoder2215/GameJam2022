
using Nancy.Hosting.Self;
static class Program
{
    public static Dictionary<string, int> PlayerIP = new Dictionary<string, int>();

    static void Main()
    {
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
}