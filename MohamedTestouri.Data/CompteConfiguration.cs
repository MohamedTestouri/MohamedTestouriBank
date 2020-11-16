using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohamedTestouri.Domain.Entities;

namespace MohamedTestouri.Data
{
   public class CompteConfiguration : EntityTypeConfiguration<Compte>
    {
      public CompteConfiguration() 
        {
            HasMany<Credit>(s => s.Credits)
                .WithMany(C => (ICollection<Compte>)C.Comptes)
                .Map(Cs =>
                 {
                     Cs.MapLeftKey("CreditId");
                     Cs.MapRightKey("AgenceId");
                     Cs.ToTable("AgenceCredit");
                 });
        
        }
    }
}
