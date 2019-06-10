using MultiAplicacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public class SQLClientMethods : ClientMethods
    {
        private readonly AppDbContext context;

        public SQLClientMethods(AppDbContext context)
        {
            this.context = context;
        }
        public int IdClientSelected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Client AddClient(Client client)
        {
            context.Add(client);
            context.SaveChanges();
            return client;
        }

        public Client DeleteClient(int Id)
        {
            Client client = context.Clients.Find(Id);
            if (client != null)
            {
                context.Clients.Remove(client);
                context.SaveChanges();
            }
            return client;
        }

        public Client GetClient(int Id)
        {
            return context.Clients.Find(Id);
        }

        public IEnumerable<Client> GetClientsList()
        {
            return context.Clients;
        }

        public Client UpdateClient(Client client_changes)
        {
            var client = context.Clients.Attach(client_changes);
            client.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return client_changes;
        }
    }
}
