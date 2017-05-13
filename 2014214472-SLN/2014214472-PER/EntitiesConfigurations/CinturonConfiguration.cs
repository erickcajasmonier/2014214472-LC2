using _2014214472_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.EntitiesConfigurations
{
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
            //Configuracion de tabla
            ToTable("Cinturones");
            HasKey(a => a.CinturonId);
        }
    }
}
