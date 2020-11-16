using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
    public class Utilisateur
    {
        
        [Key]
        public int UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
