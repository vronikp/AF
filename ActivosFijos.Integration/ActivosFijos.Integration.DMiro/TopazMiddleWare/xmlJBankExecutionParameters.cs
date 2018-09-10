using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration.DMiro.TopazMiddleWare
{
    public class xmlJBankExecutionParameters
    {
        public authentication authentication { get; set; }

        public xmlJBankExecutionParameters()
        {

            //this.authentication = new authentication() { type = "", userName = ConfigurationManager.AppSettings["userMiddle"].ToString(), password = ConfigurationManager.AppSettings["passMiddle"].ToString(), sessionID = 1 };
        }
        
        public xmlJBankExecutionParameters(string _userName, string _password, int _sessionID)
        {
            this.authentication = new authentication() { type = "", userName = _userName, password = _password, sessionID = _sessionID };
        }
    }

    public class authentication
    {
        public String type { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public int sessionID { get; set; }
    }
}
