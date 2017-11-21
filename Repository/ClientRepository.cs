using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessInterfaces;
using Model;


namespace Repository
{
    public sealed class ClientRepository : IClientRepository, IDisposable
    {
        private DAL.ServiceCenter context = new DAL.ServiceCenter();

        public Client GetClientsById(int id)
        {
            if(id > 0)
            {
                var dbclient = context.Clients.Find(id);
                var client = new Model.Client(); ;
                ConvertionsTypes.ConvertDALClientToIClient(dbclient, client);
                return client;
            }
            return null;
        }

        public IEnumerable<Client> GetClientsByName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                
                return context.Clients.Where(c=> c.Name.StartsWith(name)).ToArray().Select(c =>
                {
                    var client = new Client();
                    ConvertionsTypes.ConvertDALClientToIClient(c, client);
                    return client;
                });
            }
            return null;
        }

        public IEnumerable<Client> GetClientsByMobilePhone(string phone)
        {
            if (!String.IsNullOrEmpty(phone))
            {
                return context.Clients.Where(c => c.Phone.Contains(phone)).ToArray().Select(c =>
                {
                    var client = new Client();
                    ConvertionsTypes.ConvertDALClientToIClient(c, client);
                    return client;
                });
            }
            return null;
        }

        public IEnumerable<Client> GetClientsByPhone(string mobilePhone)
        {
            if (!String.IsNullOrEmpty(mobilePhone))
            {
                return context.Clients.Where(c => c.MobilePhone.Contains(mobilePhone)).ToArray().Select(c =>
                {
                    var client = new Client();
                    ConvertionsTypes.ConvertDALClientToIClient(c, client);
                    return client;
                });
            }
            return null;
        }

        public IEnumerable<Client> GetClientsByPassport(string seria, string number)
        {
            if (!String.IsNullOrEmpty(seria) && !String.IsNullOrEmpty(number))
            {
                return context.Clients.Where(c => c.PassportSeria == seria && c.PassportNumber == number).ToArray().Select(c =>
                {
                    var client = new Client();
                    ConvertionsTypes.ConvertDALClientToIClient(c, client);
                    return client;
                });
            }
            return null;
        }


        public void AddItem(Client item)
        {
            DAL.Client dbClient = new DAL.Client();
            if (ConvertionsTypes.ConvertIClientToDALClient(item, dbClient))
            {
                try
                {
                    context.Clients.Add(dbClient);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                }
            }
        }

        public void ChangeItem(Client item)
        {
            try
            {
                var selectedClient = context.Clients.Where(c => c.Id == item.Id).First();
                ConvertionsTypes.ConvertIClientToDALClient(item, selectedClient);
                context.SaveChanges();
            }
            catch (ArgumentNullException e) { }
        }

        public void DeleteItem(Client item)
        {
            if(item != null)
            {
                try
                {
                    DAL.Client dbClient = new DAL.Client();
                    ConvertionsTypes.ConvertIClientToDALClient(item, dbClient);
                    context.Clients.Remove(dbClient);
                    context.SaveChanges();
                }
                catch (Exception) { }
            }
            
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Client> GetAll()
        {
            return context.Clients.ToArray().Select(c =>
            {
                var cl = new Client();
                ConvertionsTypes.ConvertDALClientToIClient(c, cl);
                return cl;
             });
        }

        public IEnumerable<Client> GetAllByDate(DateTime begin, DateTime end)
        {
            if ((begin!=null) && (end!=null))
            {
                return context.Clients.Where(c => c.RegistrationDate >= begin && c.RegistrationDate <= end).ToArray().Select(c =>
                {
                    var client = new Client();
                    ConvertionsTypes.ConvertDALClientToIClient(c, client);
                    return client;
                });
            }
            return null;
        }
    }
}
