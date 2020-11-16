using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohamedTestouri.Domain.Entities;

namespace MohamedTestouri.Data
{
    class AgenceConfiguration : EntityTypeConfiguration<Agence>
    {
        public AgenceConfiguration()
        {
            HasMany<Compte>(s => s.Comptes)
                .WithRequired(s => s.Agences)
                .HasForeignKey(s => s.CompteId);

        }

    }
}
