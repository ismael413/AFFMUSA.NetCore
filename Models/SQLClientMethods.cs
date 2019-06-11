using PruebasNetCore.Models;
using PruebasNetCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public class SQLClientMethods : ClientMethods
    {
        private readonly ApplicationDbContext context;

        public SQLClientMethods(ApplicationDbContext context)
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
            Client client = context.Client.Find(Id);
            if (client != null)
            {
                context.Client.Remove(client);
                context.SaveChanges();
            }
            return client;
        }

        public Client GetClient(int Id)
        {
            return context.Client.Find(Id);
        }

        public IEnumerable<Client> GetClientsList()
        {
            return context.Client;
        }

        public Client UpdateClient(Client client_changes)
        {
            var client = context.Client.Attach(client_changes);
            client.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return client_changes;
        }
    }
}
