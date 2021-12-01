using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Visigothia.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="UserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddUserProfileDirectoryPathProvider_Old(this IServiceCollection services)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, UserProfileDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUserProfileDirectoryPathProvider> AddUserProfileDirectoryPathProviderAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IUserProfileDirectoryPathProvider>(() => services.AddUserProfileDirectoryPathProvider_Old());
            return serviceAction;
        }
    }
}
