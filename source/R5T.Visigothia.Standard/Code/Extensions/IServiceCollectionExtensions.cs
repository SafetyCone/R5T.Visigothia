using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Visigothia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="UserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddUserProfileDirectoryPathProvider(this IServiceCollection services)
        {
            Default.IServiceCollectionExtensions.AddUserProfileDirectoryPathProvider(services);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUserProfileDirectoryPathProvider> AddUserProfileDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IUserProfileDirectoryPathProvider>(() => services.AddUserProfileDirectoryPathProvider());
            return serviceAction;
        }
    }
}
