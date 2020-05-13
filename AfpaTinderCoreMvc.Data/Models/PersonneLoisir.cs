using System;
using System.Collections.Generic;
using System.Text;

namespace AfpaTinderCoreMvc.Data.Models
{
    public class PersonneLoisir
    {
        public int LoisirId { get; set; }
        public Loisir Loisir { get; set; }
        public int PersonneId { get; set; }
        public Personne Personne { get; set; }
    }
}
