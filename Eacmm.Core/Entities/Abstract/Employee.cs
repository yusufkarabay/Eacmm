using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TC { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Mail { get; set; } 
        public bool IsUser { get; set; } = false;
        public bool IsAdmin { get; set; } = false;


        //[JsonIgnore]
        //[IgnoreDataMember]
        //public virtual List<Cabinet>? Cabinets { get; set; } = new List<Cabinet>();

        //[JsonIgnore]
        //[IgnoreDataMember]
        //public virtual List<EntranceCard>? EntranceCards { get; set; } = new List<EntranceCard>();


        //[JsonIgnore]
        //[IgnoreDataMember]
        //public virtual List<GuestCard>? GuestCards { get; set; } = new List<GuestCard>();


        //[JsonIgnore]
        //[IgnoreDataMember]
        //public virtual List<Headset>? Headsets { get; set; } = new List<Headset>();

        //[JsonIgnore]
        //[IgnoreDataMember]
        //public virtual List<Drawer>? Drawers { get; set; } = new List<Drawer>();


        public Guid DepartmentId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Department Department { set; get; }

    }
}
