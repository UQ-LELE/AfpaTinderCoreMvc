using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AfpaTinderCoreMvc.Data.Models
{
    public class Loisir
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Nom { get; set; }

        public bool Statut { get; set; }

        public List<PersonneLoisir> PersonneLoisirs { get; set; }
    }
}
