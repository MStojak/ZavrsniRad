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
    public class AddClient : IAddClient
    {
        IClientRepository clientRepository;
        public AddClient(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        public void Execute(Client client)
        {
            clientRepository.Add(client);
        }
    }
}
