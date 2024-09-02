
//----------------------
// <auto-generated>
//     Generated by LazyMagic. Do not modify, your changes will be overwritten.
//     If you need to register additional services, do it in a separate class.
//     Also, if you need to register a service with a different lifetime, do it in a seprate class.
//     Note that we are using Try* so if you register a service with the same interface first, that 
//     registration will be used.   
//     We very intentionally use Singletons for our Repos. This is because we want to be able to 
//     maintain state for caching etc. when necessary. 
// </auto-generated>
//----------------------
namespace SubscriptionsSchemaRepo;
public static class SubscriptionsSchemaRepoExtensions
{
    public static IServiceCollection AddSubscriptionsSchemaRepo(this IServiceCollection services)
    {

        services.AddAWSService<Amazon.DynamoDBv2.IAmazonDynamoDB>();
		services.TryAddSingleton<ILzNotificationRepo, LzNotificationRepo>();
		services.TryAddSingleton<ILzNotificationsPageRepo, LzNotificationsPageRepo>();
		services.TryAddSingleton<ILzSubscriptionRepo, LzSubscriptionRepo>();



        return services;
    }
}
