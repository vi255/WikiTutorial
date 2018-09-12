﻿using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiTutorial.ClienteServices.DTOs;

namespace WikiTutorial.ClienteServices
{
    public interface IClienteAppService : IApplicationService
    {

        Task<CreateClienteOutput> CreateCliente(CreateClienteInput input);
        Task<UpdateClienteOutput> UpdateCliente(UpdateClienteInput input);
        Task DeleteCliente(long id);
        Task<GetClienteByIdOutput> GetById(long id);
        Task<GetAllClienteOutput> GetAllCliente();
    }
}
