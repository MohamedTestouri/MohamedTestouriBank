using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
    public class Agence
    {
        public int AgenceId { get; set; }
        public string Nom { get; set; }
        public int NombreEmploye { get; set; }
        public virtual ICollection<Compte> Comptes { get; set; }
}
    }

