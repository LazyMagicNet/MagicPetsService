
//----------------------
// <auto-generated>
//     Generated by LazyMagic, do not edit directly. Changes will be overwritten.
//     Implement another class for registrations not directly generated by LazyMagic.
// </auto-generated>
//----------------------
namespace SubscriptionsModule
{
    public static class SubscriptionsModuleRegistrations 
    {
        public static IServiceCollection AddSubscriptionsModule(this IServiceCollection services) 
        {
            services.TryAddSingleton<ISubscriptionsModuleAuthorization, SubscriptionsModuleAuthorization>();
            services.TryAddSingleton<ISubscriptionsModuleController, SubscriptionsModuleControllerImpl>();
            services.AddSharedSchemaRepo();
			services.AddStoreSchemaRepo();
			services.AddSubscriptionsSchemaRepo();
            return services;            
        }
    }
}
