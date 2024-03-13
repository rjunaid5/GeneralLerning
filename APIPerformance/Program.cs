using System;
using System.Collections.Generic;

class LoadBalancer
{
    private List<string> servers;
    private int currentIndex;

    public LoadBalancer(List<string> servers)
    {
        if (servers == null || servers.Count == 0)
        {
            throw new ArgumentException("At least one server is required.");
        }

        this.servers = servers;
        this.currentIndex = 0;
    }

    public string DistributeRequest()
    {
        // Get the next server in a round-robin fashion
        string selectedServer = servers[currentIndex];

        // Update the index for the next request
        currentIndex = (currentIndex + 1) % servers.Count;

        Console.WriteLine($"Request distributed to: {selectedServer}");

        return selectedServer;
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        List<string> serverList = new List<string> { "Server1", "Server2", "Server3" };

        LoadBalancer loadBalancer = new LoadBalancer(serverList);

        // Simulate requests being distributed
        for (int i = 1; i <= 10; i++)
        {
            string selectedServer = loadBalancer.DistributeRequest();
            // Process the request on the selected server
            // ...
        }
    }
}
