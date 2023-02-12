namespace Proxy_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Proxy object
            Subject proxy = new Proxy();

            // Call the Request method on the Proxy object
            string result = proxy.Request();
            Console.WriteLine(result);
        }
    }
}