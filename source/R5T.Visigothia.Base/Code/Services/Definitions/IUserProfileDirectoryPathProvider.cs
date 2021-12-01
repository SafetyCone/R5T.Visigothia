using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Visigothia
{
    [ServiceDefinitionMarker]
    public interface IUserProfileDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetUserProfileDirectoryPath();
    }
}
