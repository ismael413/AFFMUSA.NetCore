using AFFMUSA.Models.Lists;
using PruebasNetCore.Models;
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
            clients = new List<Client>(){
                new Client() {
                    ClientID = 1,
                    Company_Name = "HR Company",
                    Contact_Name = "Julio",
                    Job_Title = "Encargado de Suministros",
                    Email = "julio@hrcompany.com",
                    Phone = "890-878-8979",
                    Ext = 123,
                    Fax = "7487583758",
                    City = "Texas",
                    ZipCode = 54000,
                    Notes = "good worker"
                }
            };
        }

        public Client AddClient(Client client)
        {
            //ESPECIFICAR INDICE DE CLIENTE A AGREGAR EN LA 
            //LISTA DE CLIENTES
            client.ClientID = clients.Max(c => c.ClientID + 1);
            //AGREAGAR CLIENTE A LA LISTA
            clients.Add(client);
            return client;
            
        }

        public Client DeleteClient(int Id)
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

        public IEnumerable<Client> GetClientsList()
        {
            return clients;
        }

        public Client UpdateClient(Client client_changes)
        {
            //OBTENER CLIENTE DE LA LISTA CON EL ID ESPECIFICADO
            Client client = clients.FirstOrDefault(c => c.ClientID == client_changes.ClientID);

            //VER SI ESE CLIENTE EXISTE
            if (client != null)
            {
                client.Company_Name = client_changes.Company_Name;
                client.Contact_Name = client_changes.Contact_Name;
                client.Job_Title = client_changes.Job_Title;
                client.Email = client_changes.Email;
                client.Phone = client_changes.Phone;
                client.Ext = client_changes.Ext;
                client.Fax = client_changes.Fax;
                client.City = client_changes.City;
                client.ZipCode = client_changes.ZipCode;
                client.Notes = client_changes.Notes;
            }
            //RETORNAR CAMBIOS
            return client;

        }
    }
}
