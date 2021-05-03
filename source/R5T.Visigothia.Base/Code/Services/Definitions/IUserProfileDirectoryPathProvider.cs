using System;
using System.Threading.Tasks;


namespace R5T.Visigothia
{
    public interface IUserProfileDirectoryPathProvider
    {
        Task<string> GetUserProfileDirectoryPath();
    }
}
