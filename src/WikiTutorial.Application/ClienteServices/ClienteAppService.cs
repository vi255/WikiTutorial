using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiTutorial.ClienteServices.DTOs;
using WikiTutorial.Entities.ClienteEntity;
using WikiTutorial.Entities.ClienteEntity.Manager;

namespace WikiTutorial.ClienteServices
{
    public class ClienteAppService : ApplicationService, IClienteAppService
    {
        private IClienteManager _clienteManager;

        public ClienteAppService(IClienteManager clienteManager)
        {
            _clienteManager = clienteManager;
        }

        public async Task<CreateClienteOutput> CreateCliente(CreateClienteInput input)
        {
            var cliente = input.MapTo<Cliente>();
            var createdClienteId = await _clienteManager.Create(cliente);
            return new CreateClienteOutput
            {
                Id = createdClienteId
            };
        }

            public async Task DeleteCliente(long id)
            {
                await _clienteManager.Delete(id);
            }

            public async Task<GetAllClienteOutput> GetAllCliente()
            {
                var cliente = await _clienteManager.GetAllList();
                return new GetAllClienteOutput { Cliente = Mapper.Map<List<GetAllClienteItem>>(cliente) };
            }

            public async Task<GetClienteByIdOutput> GetById(long id)
            {
                var cliente = await _clienteManager.GetById(id);
                return Mapper.Map<GetClienteByIdOutput>(cliente);

            }

        public async Task<UpdateClienteOutput> UpdateCliente(UpdateClienteInput input)
        {
            var cliente = input.MapTo<Cliente>();
            var clienteAtualizado = await _clienteManager.Update(cliente);
            return clienteAtualizado.MapTo<UpdateClienteOutput>();
        }

    }

}
