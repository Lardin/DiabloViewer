using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DiabloViewer
{
    [DataContract]
    class DiabloProfile
    {
        [DataMember(Name = "guildName")]
        public String GuildName { get; set; }
        [DataMember(Name = "code")]
        public String Code { get; set; }
        [DataMember(Name = "reason")]
        public String Reason { get; set; }
    }
}
