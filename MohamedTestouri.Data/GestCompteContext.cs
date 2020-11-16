using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohamedTestouri.Domain.Entities;

namespace MohamedTestouri.Data
{
    public class GestCompteContext:DbContext
    {
        public GestCompteContext():base("name=GestCompteBD")
        {

        }
        public DbSet<Agence> Agences { get; set; }
        public DbSet <Compte> Comptes {get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /* modelBuilder.Configurations.Add(new CompteConfiguration());
             modelBuilder.Configurations.Add(new AgenceConfiguration());
             modelBuilder.Configurations.Add(new CreditConfiguration());
        */
            modelBuilder.Entity <Client> ().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable(" Client");
            });
            modelBuilder.Entity <ChefAgence> ().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ChefAgence");
            });

        }

        private EntityTypeConfiguration<object> newCompteConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}
