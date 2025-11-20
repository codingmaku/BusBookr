using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class Session
    {
        public static string UserId { get; set; }
        public static string UserEmail { get; set; }
        public static string CurrentAdminSelected { get; set; }
        public static string CurrentBookerSelectedEmail{ get; set; }
        public static string CurrentBookerSelectedId { get; set; }

    }
}
