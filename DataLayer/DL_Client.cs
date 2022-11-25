using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Client
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public IQueryable<Client> GetClients()
        {
            IQueryable<Client> clients;

            try
            {
                clients =
                    from c in db.Clients
                    select new Client
                    {
                        Id = c.Id,
                        Document = c.Document,
                        FullName = c.FullName,
                        Mail = c.Mail,
                        Address = c.Address,
                        Phone = c.Phone,
                        State = c.State
                    };

                //return users;
            }
            catch
            {
                clients = (IQueryable<Client>)new List<Client>();
            }

            return clients;
        }

        public Client GetClientByDocument(string document)
        {
            Client client = new Client();

            try
            {
                client = db.Clients.Where(o => o.Document == document).FirstOrDefault();
            }
            catch
            {
                client = new Client();
            }

            return client;
        }

        public string CreateClient(Client newClient)
        {
            string result = "";
            Client consultClient = db.Clients.Where(o => o.Document == newClient.Document).FirstOrDefault();

            try
            {
                if (consultClient == null)
                {
                    Client client = new Client()
                    {
                        Document = newClient.Document,
                        FullName = newClient.FullName,
                        Mail = newClient.Mail,
                        Address = newClient.Address,
                        Phone = newClient.Phone,
                        State = newClient.State
                    };

                    db.Add(client);
                    db.SaveChanges();

                    result = "El cliente " + newClient.FullName + " se ha creado correctamente.";
                }
                else
                {
                    result = "Error: El cliente con CC: " + newClient.Document + " ya existe en base de datos";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }

        public string UpdateClient(int id, Client dataClientUpdate)
        {
            Client client = new Client();
            string result = "";
            try
            {
                client = db.Clients.Where(o => o.Id == id).FirstOrDefault();
                Client dataClient = db.Clients.Where(o => o.Document == dataClientUpdate.Document).FirstOrDefault();

                if (dataClient == null || client.Id == dataClient.Id)
                {
                    client.Id = dataClientUpdate.Id;
                    client.Document = dataClientUpdate.Document;
                    client.FullName = dataClientUpdate.FullName;
                    client.Mail = dataClientUpdate.Mail;
                    client.Address = dataClientUpdate.Address;
                    client.Phone = dataClientUpdate.Phone;
                    client.State = dataClientUpdate.State;

                    db.SaveChanges();

                    result = "El cliente " + client.FullName + " se ha editado correctamente.";
                }
                else
                {
                    result = "Error: El cliente con CC: " + client.Document + " no se ha editato. Esta intentando editar la cédula y ya pertenece a otro cliente";
                }

            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }

            return result;
        }
    }
}
