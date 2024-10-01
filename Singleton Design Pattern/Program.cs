namespace Singleton.NetOptimized;

using static System.Console;
using System;
using System.Collections.Generic;
using Singleton_Design_Pattern;

public class Program
{
    public static void Main()
    {
        var b1 = LoadBalancer.GetLoadBalancer();
        var b2 = LoadBalancer.GetLoadBalancer();
        var b3 = LoadBalancer.GetLoadBalancer();
        var b4 = LoadBalancer.GetLoadBalancer();

        // Confirm these are the same instance
        if (b1 == b2 && b2 == b3 && b3 == b4)
        {
            WriteLine("Same instance\n");
        }

        var balancer = LoadBalancer.GetLoadBalancer();

        // Load balance 15 requests for a server
        for (int i = 0; i < 15; i++)
        {
            var server = balancer.NextServer.Name;
            WriteLine("Dispatch request to: " + server);
        }

        // Wait for user
        ReadKey();
    }
}

public record Server(string Name, string Ip);

