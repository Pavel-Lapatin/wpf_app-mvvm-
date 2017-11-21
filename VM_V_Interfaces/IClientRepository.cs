using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessInterfaces
{
    public interface IClientRepository : IBaseRepository<Client>
    {
       Client GetClientsById(int id);      
       IEnumerable<Client> GetClientsByName(string name);       
       IEnumerable<Client> GetClientsByMobilePhone(string phone);
       IEnumerable<Client> GetClientsByPhone(string mobilePhone);
       IEnumerable<Client> GetClientsByPassport(string seria, string number);      
    }
}
