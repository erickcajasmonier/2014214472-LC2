using _2014214472_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.EntitiesConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
        {
            //Configuracion de tabla
            ToTable("Asientos");
            HasKey(a => a.AsientoId);





            //Configuracion de relaciones
            HasRequired(a => a.Cinturon)
                .WithRequiredPrincipal(a => a.Asiento);
        }
    }
}
