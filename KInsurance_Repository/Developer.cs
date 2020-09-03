using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KInsurance_Repository
{
    public class Developer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public bool PluralSightAccount { get; set; }
        public string Title { get; set; }

        public Developer(int id, string lastName, bool pluralSightAccount, string title )
        {
            Id = id;
            LastName = lastName;
            PluralSightAccount = pluralSightAccount;
            Title = title;
        }


    }
}
