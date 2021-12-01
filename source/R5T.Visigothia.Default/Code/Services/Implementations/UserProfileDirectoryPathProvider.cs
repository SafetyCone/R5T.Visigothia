using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Visigothia.Default
{
    [ServiceImplementationMarker]
    public class UserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider, IServiceImplementation
    {
        public Task<string> GetUserProfileDirectoryPath()
        {
            var userProfileDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            return Task.FromResult(userProfileDirectoryPath);
        }
    }
}
