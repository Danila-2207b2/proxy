using Proxy_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ISubject proxyAdmin = new Proxy("admin");

        Console.WriteLine(proxyAdmin.Request("Req"));
        Console.WriteLine(proxyAdmin.Request("Request"));

        ISubject proxyGuest = new Proxy("guest");

        Console.WriteLine(proxyGuest.Request("Req"));
        Console.WriteLine(proxyGuest.Request("Request"));
    }
}