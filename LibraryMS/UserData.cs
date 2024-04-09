using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS
{
    internal class UserData
    {
        public string Id ;
        public string Password;
        public int GetId(string id)
        {
            Id = id;
            return 1;
        }
        public int GetPassword(string str)
        {
           Password=str;
            return 1;
        }
    }
}
