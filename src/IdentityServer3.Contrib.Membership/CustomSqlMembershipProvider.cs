using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer3.Contrib.Membership
{
    public class CustomSqlMembershipProvider : System.Web.Security.SqlMembershipProvider
    {
        public string GetClearTextPassword(string encryptedPwd)
        {
            byte[] encodedPassword = Convert.FromBase64String(encryptedPwd);
            byte[] bytes = this.DecryptPassword(encodedPassword);
            if (bytes == null)
            {
                return null;
            }
            return Encoding.Unicode.GetString(bytes, 0x10, bytes.Length - 0x10);

        }
    }
}
