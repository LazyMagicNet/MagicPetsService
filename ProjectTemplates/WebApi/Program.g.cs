public partial class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                var stsClient = services.GetRequiredService<IAmazonSecurityTokenService>();
                var identity = stsClient.GetCallerIdentityAsync(new GetCallerIdentityRequest()).GetAwaiter().GetResult();
                Console.WriteLine($"AWS identity: {identity.Arn}");
            }
            catch { throw new Exception("Could not authenticate with AWS"); }
        }
        host.Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseContentRoot(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    public static MemoryStream GenerateStreamFromString(string s)
    {
        var byteArray = Encoding.UTF8.GetBytes(s);
        var stream = new MemoryStream(byteArray);
        return stream;
    }
}
