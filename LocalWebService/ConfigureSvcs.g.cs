
// Generated by LazyMagic - modifications will be overwritten

public partial class Startup
{
    public void ConfigureSvcs(IServiceCollection services)
    {
        services.AddSubscriptionsModule();
		services.AddStoreModule();
		services.AddConsumerModule();
		services.AddPublicModule();
    }
}
