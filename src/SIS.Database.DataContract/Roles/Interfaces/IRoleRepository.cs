using System.Threading.Tasks;
using HirePersonality.Database.DataContract.Authorization.RAOs;

namespace HirePersonality.Database.DataContract.Roles.Interfaces
{
    public interface IRoleRepository
    {
        Task<bool> AddUserToRole(ReceivedExistingUserRAO User, string Role);
    }
}