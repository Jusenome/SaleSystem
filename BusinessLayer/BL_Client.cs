using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BL_Client
    {
        private DL_Client oDLClient = new DL_Client();

        public IQueryable<Client> GetClients()
        {
            return oDLClient.GetClients();
        }

        public string CreateClient(Client client)
        {
            string result = oDLClient.CreateClient(client);

            return result;
        }

        public string UpdateClient(int id, Client dataClientUpdate)
        {
            string result = oDLClient.UpdateClient(id, dataClientUpdate);

            return result;
        }
    }
}
