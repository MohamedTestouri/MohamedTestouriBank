using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohamedTestouri.Domain.Entities;

namespace MohamedTestouri.Data
{
    class CreditConfiguration : EntityTypeConfiguration<Credit>
    {
        public CreditConfiguration()
        {
            HasMany<Compte>(s => s.Comptes)
                .WithRequired(s => (Credit)s.Credits)
                .HasForeignKey(s => s.CompteId);

        }

    }
}