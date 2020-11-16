using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
    public class Credit
    {
        public int CreditId { get; set; }
        public float Somme { get; set; }
        public DateTime DateCredit { get; set; }
        public float TauxInteret { get; set; }
 
        public ICollection <Compte> Comptes { get; set; }
            }
    }


