using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public interface ClientMethods
    {
        int IdClientSelected { get; set; }
        Client GetClient(int Id);
        IEnumerable<Client> GetClients();
        Client Add(Client client);
        Client Update(Client client_changes);
        Client Delete(int Id);
    }
}
