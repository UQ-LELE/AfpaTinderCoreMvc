using AfpaTinderCoreMvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfpaTinderCoreMvc.Data.Data
{
    public class DataPersonne
    {
        private readonly ApplicationDbContext _context;

        public DataPersonne(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public List<Personne> GetPersonnes()
        {
            return (_context.Personnes.ToList());
        }
    }
}
