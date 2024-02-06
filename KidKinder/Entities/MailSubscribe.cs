using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class MailSubscribe
    {
        public int MailSubscribeId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
    }
}