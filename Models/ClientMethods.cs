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
        IEnumerable<Client> GetClientsList();
        Client AddClient(Client client);
        Client UpdateClient(Client client_changes);
        Client DeleteClient(int Id);
    }
}
