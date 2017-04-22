using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Models
{
   public class Vehicule
    {
        public String Owner { get; set; }
        public String OwnerTel { get; set; }
        public String Name { get; set; }
        public String Lieu { get; set; }

        public String Quantite { get; set; }

        public int Prix { get; set; }

        public String Date { get; set; }
        public String ImageVehicule { get; set; }

        public String ImageVehicule2 { get; set; }

        public String ImageVehicule3 { get; set; }
        public String OwnerImg { get; set; }
        public int idowner { get; set; }

    }
}
