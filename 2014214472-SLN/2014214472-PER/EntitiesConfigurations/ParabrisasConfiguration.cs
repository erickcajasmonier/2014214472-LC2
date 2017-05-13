using _2014214472_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.EntitiesConfigurations
{
    public class ParabrisasConfiguration : EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisasConfiguration()
        {
            //Configuracion de tabla
            ToTable("Parabrisas");
            HasKey(a => a.ParabrisasId);
        }
    }
}
