using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
    class CarteBancaire
    {
        public int CarteBancaireId { get; set; }
        public int Code { get; set; }
        public float Montant { get; set; }
        public int CompteId { get; set; }
        public Compte compte { get; set; }
    }
}
