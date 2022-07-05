using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Clients
{
    public class EditClient : IEditClient
    {
        IClientRepository clientRepository;
        public EditClient(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        public void Execute(Client client)
        {
            clientRepository.Update(client);
        }
    }
}
