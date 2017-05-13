using _2014214472_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.EntitiesConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            //Configuracion de tabla
            ToTable("Llantas");
            HasKey(a => a.LlantaId);
        }
    }
}
