using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Visigothia.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="UserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUserProfileDirectoryPathProvider> AddUserProfileDirectoryPathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IUserProfileDirectoryPathProvider>(services => services.AddUserProfileDirectoryPathProvider());
            return serviceAction;
        }
    }
}
