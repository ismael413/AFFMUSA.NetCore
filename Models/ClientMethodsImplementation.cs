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
            if (clients == null)
            {
                clients = new List<Client>()
            {
                 new Client() {
                    Id = 1,
                    Company_Name = "HR Company",
                    Contact_Name = "Gregorio Hernandez",
                    Job_Title = "Administrador",
                    Email = "gregorio@hrcomp.com",
                    Phone = "706-567-8907",
                    Ext = "456",
                    Fax = "890-789-7887",
                    City = "Miami",
                    Notes = "good worker",
                },
            new Client()
            {
                Id = 2,
                Company_Name = "HR Company",
                Contact_Name = "Gregorio Hernandez",
                Job_Title = "Administrador",
                Email = "gregorio@hrcomp.com",
                Phone = "706-567-8907",
                Ext = "456",
                Fax = "890-789-7887",
                City = "Miami",
                Notes = "good worker",
            },

            new Client()
            {
                Id = 3,
                Company_Name = "HR Company",
                Contact_Name = "Gregorio Hernandez",
                Job_Title = "Administrador",
                Email = "gregorio@hrcomp.com",
                Phone = "706-567-8907",
                Ext = "456",
                Fax = "890-789-7887",
                City = "Miami",
                Notes = "good worker",
            }

            };
            }
        }


        public Client Add(Client client)
        {
            //ESPECIFICAR INDICE DE CLIENTE A AGREGAR EN LA 
            //LISTA DE CLIENTES
            client.Id = clients.Max(c => c.Id + 1);
            //AGREAGAR CLIENTE A LA LISTA
            clients.Add(client);
            return client;
        }

        public Client Delete(int Id)
        {
            //OBTENER CLIENTE DE UNA LISTA DE CLIENTES
            Client client = clients.FirstOrDefault(c => c.Id == Id);
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
            return clients.FirstOrDefault(c => c.Id == Id);
        }

        public IEnumerable<Client> GetClients()
        {
            return clients;
        }

        public Client Update(Client client_changes)
        {
            //OBTENER CLIENTE DE LA LISTA CON EL ID ESPECIFICADO
            Client client = clients.FirstOrDefault(c => c.Id == client_changes.Id);

            //VER SI ESE CLIENTE EXISTE
            if (client != null)
            {
                //APLICAR CAMBIO A DICHO CLIENTE
                client.Company_Name = client_changes.Company_Name;
                client.Contact_Name = client_changes.Contact_Name;
                client.Job_Title = client_changes.Job_Title;
                client.Email = client_changes.Email;
                client.Phone = client_changes.Phone;
                client.Ext = client_changes.Ext;
                client.Fax = client_changes.Fax;
                client.City = client_changes.City;
                client.Notes = client_changes.Notes;
            }
            //RETORNAR CAMBIOS
            return client;

        }
    }
}
