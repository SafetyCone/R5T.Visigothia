using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.Visigothia.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="UserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddUserProfileDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, UserProfileDirectoryPathProvider>();

            return services;
        }
    }
}
