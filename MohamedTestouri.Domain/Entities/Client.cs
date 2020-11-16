using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
    public class Client : Utilisateur
    {
        public int ClientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }
    }
}
