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
    public class ViewAllClients : IViewAllClients
    {
        IClientRepository clientRepository;
        public ViewAllClients(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        public IEnumerable<Client> Execute()
        {
            return clientRepository.GetAll();
        }
    }
}
