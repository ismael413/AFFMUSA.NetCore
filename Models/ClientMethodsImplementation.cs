using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public class ClientMethodsImplementation : ClientMethods
    {
        public List<Client> clients;
        public int IdClientSelected { get; set; }

        public ClientMethodsImplementation()
        {
        }

        public Client Add(Client client)
        {
            //ESPECIFICAR INDICE DE CLIENTE A AGREGAR EN LA 
            //LISTA DE CLIENTES
            client.ClientID = clients.Max(c => c.ClientID + 1);
            //AGREAGAR CLIENTE A LA LISTA
            clients.Add(client);
            return client;
        }

        public Client Delete(int Id)
        {
            //OBTENER CLIENTE DE UNA LISTA DE CLIENTES
            Client client = clients.FirstOrDefault(c => c.ClientID == Id);
            //VERIFICAR SI EXISTE
            if (client != null)
            {
                //ELIMINAR DICHO CLIENTE
                clients.Remove(client);
            }
            //RETORNAR CLIENTE ELIMIADO
            return client;
        }

        public Client GetClient(int Id)
        {
            return clients.FirstOrDefault(c => c.ClientID == Id);
        }

        public IEnumerable<Client> GetClients()
        {
            return clients;
        }

        public Client Update(Client client_changes)
        {
            //OBTENER CLIENTE DE LA LISTA CON EL ID ESPECIFICADO
            Client client = clients.FirstOrDefault(c => c.ClientID == client_changes.ClientID);

            //VER SI ESE CLIENTE EXISTE
            if (client != null)
            {
                //APLICAR CAMBIO A DICHO CLIENTE
  
            }
            //RETORNAR CAMBIOS
            return client;

        }
    }
}
