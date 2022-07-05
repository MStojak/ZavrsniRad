using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class ClientRepository : IClientRepository
    {
        private List<Client> clients;

        public ClientRepository()
        {
            clients = new List<Client>()
            {
                new Client { Id = 0, Name = "Silvija Šesto", Adress = "Hebrangova", OIB = "0000000001", Phone = "0911010101", Email = "silvija.sesto@gmail.com" },
                new Client { Id = 1, Name = "HDKDM", Adress = "Masarikova", OIB = "0000000002", Phone = "09110292301", Email = "hdkdm@gmail.com" },
                new Client { Id = 2, Name = "Knjiga u centru", Adress = "Prečko", OIB = "0000000003", Phone = "0911393901", Email = "knjiga.u.centru@gmail.com" }
            };
        }
        public void Add(Client client)
        {
            if(clients.Any(x => x.Name.Equals(client.Name, StringComparison.OrdinalIgnoreCase) || x.OIB.Equals(client.OIB, StringComparison.OrdinalIgnoreCase)))
                return;
            client.Id = GetMinimalId() + 1;
            clients.Add(client);
        }

        public void Delete(int id)
        {
            clients?.Remove(GetById(id));
        }

        public IEnumerable<Client> GetAll()
        {
            return clients;
        }

        public Client GetById(int id)
        {
            return clients?.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Client client)
        {
            var categoryToUpdate = GetById(client.Id);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = client.Name;
                categoryToUpdate.Adress = client.Adress;
                categoryToUpdate.OIB = client.OIB;
                categoryToUpdate.Phone = client.Phone;
                categoryToUpdate.Email = client.Email;
            }
        }

        private int GetMinimalId()
        {
            var id = -1;
            if (clients.Count != 0)
                id = clients.Max(x => x.Id);
            return id == -1 ? 0 : id;
        }
    }
}
