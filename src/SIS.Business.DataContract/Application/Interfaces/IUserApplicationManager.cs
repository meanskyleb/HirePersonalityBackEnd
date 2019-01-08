using HirePersonality.Business.DataContract.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.DataContract.Application.Interfaces
{
    public interface IUserApplicationManager
    {
        Task<bool> CreateApplication(ApplicationCreateDTO applicationDTO);
    }
}
