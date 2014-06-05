using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgs
{
    public class MLog
    {
        public bool Sended { get; set; }
        public string SendedMessage { get; set; }
        public string MAdress { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
    }
    public class Programs
    {
        public Guid? PROGRAMID { get; set; }
        public string PROGRAMNAME { get; set; }
    }

    public class Activities
    {
        public Guid? ACTIVITYID { get; set; }
        public string ACTIVITYNAME { get; set; }
        public string ITEMTYPE { get; set; }
    }
    public class ActivityMail
    {
        public Guid? ACTIVITYID { get; set; }
        public string EMAIL { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string USERNAME { get; set; }
        public string IDENTITYNUMBER { get; set; }
        public string GROUPNAME { get; set; }
    }
}
