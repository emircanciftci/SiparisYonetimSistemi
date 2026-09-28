using SiparisYonetimSistemi.BLL.Repository.Base;
using SiparisYonetimSistemi.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimSistemi.BLL.Repository.Entity
{
    public class UserRepository : BaseRepository<User>
    {
        public bool logincontrol(string username, string pass)
        {
            bool rtn = table.Any(x => x.UserName == username && x.Password == pass);
            if (rtn == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public User FindUserName(string username)
        {
            return table.FirstOrDefault(x => x.UserName == username);
        }
    }
}
