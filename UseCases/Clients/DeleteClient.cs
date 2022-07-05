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
    public class DeleteClient : IDeleteClient
    {
        IClientRepository clientRepository;
        public DeleteClient(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        public void Execute(int id)
        {
            clientRepository.Delete(id);
        }
    }
}
