using SiparisYonetimiD.Data;
using SiparisYonetimiD.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SiparisYonetimiD.Business.Managers
{
    public class UserManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}
