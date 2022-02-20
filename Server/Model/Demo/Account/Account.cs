using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public enum AccountType
    {
        Normal = 0,
        Blocked = 1,
        Admin = 2,
    }
    public class Account:Entity, IAwake
    {
        public string AccountName;
        public string Password;
        public long CreateTime;
        public int AccountType;
    }
}
