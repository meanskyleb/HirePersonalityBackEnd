using HirePersonality.Business.DataContract.Authorization.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.DataContract.Authorization.Interfaces
{
    public interface IAuthManager
    {
        Task<ReceivedExistingUserDTO> RegisterUser(RegisterUserDTO userDTO);
        Task<ReceivedExistingUserDTO> LoginUser(QueryForExistingUserDTO userDTO);
        Task<bool> UserExists(string user);
        Task<bool> AmIAnAdmin(int id);
    }
}
