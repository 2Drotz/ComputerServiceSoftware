using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactPC
{
    public class checkAdmin
    {
        public string Login { get; set;}// свойства получить и устанавливать значение

        public bool IsAdmin { get; }//свойство получить свойства

        public string Status => IsAdmin ? "Админ" : "Юзер"; //тернарная если админ то надпись админ и наоборот

        public checkAdmin(string login, bool isAdmin) {
            
            Login = login.Trim();
            IsAdmin = isAdmin;
        }

    }
}
