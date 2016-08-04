using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Chat
    {
        public int ChatID { get; set; }
        [Maxlength(150)]
        public string Chat { get; set; }
        public int TimeStamp { get; set; }
        public string UserID { get; set; }

    }
}