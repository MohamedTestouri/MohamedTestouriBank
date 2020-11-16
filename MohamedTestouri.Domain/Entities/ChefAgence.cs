using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedTestouri.Domain.Entities
{
    public class ChefAgence:Utilisateur
{
    public int Matricule { get; set; }
    public string Grade { get; set; }
}
}
