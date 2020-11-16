using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
   public class Compte
    {
        public int CompteId { get; set; }
        public int RIB { get; set; }
        public virtual ICollection<Credit>Credits { get; set; }
        public virtual Agence Agences { get; set; }
        public ICollection<Compte> Comptes { get; set; }
        public Compte Agence { get; set; }

        //Foreign key for Client
        public int ClientId { get; set; }
        //Foreign Key for CarteBancaire
        public int? CarteBancaire { get; set; }
        public virtual Client Client { get; set; }
       // public virtual CarteBancaire Carte { get; set; }

    }
}
