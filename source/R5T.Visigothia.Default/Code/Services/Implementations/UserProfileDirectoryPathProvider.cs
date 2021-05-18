using System;
using System.Threading.Tasks;


namespace R5T.Visigothia.Default
{
    public class UserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider
    {
        public Task<string> GetUserProfileDirectoryPath()
        {
            var userProfileDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            return Task.FromResult(userProfileDirectoryPath);
        }
    }
}
