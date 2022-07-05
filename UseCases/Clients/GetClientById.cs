using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using CoreBusiness;
using UseCases.Interfaces;

namespace UseCases.Clients
{
    public class GetClientById : IGetClientById
    {
        IClientRepository clientRepository;
        public GetClientById(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        public Client Execute(int id)
        {
            return clientRepository.GetById(id);
        }
    }
}
