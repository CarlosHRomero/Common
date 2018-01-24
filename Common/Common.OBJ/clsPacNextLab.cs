using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.OBJ
{
    [PetaPoco.TableName("lispac")]
    [PetaPoco.PrimaryKey("cod_pac", AutoIncrement = false)]
    public class clsPacNextLab
    {
        public decimal cod_pac { get; set; }
        public string doc_pac { get; set; }
        public string nom_pac { get; set; }
        public string nom_pac2 { get; set; }
        public string ape_pac { get; set; }
        public string apm_pac { get; set; }
        public Nullable<System.DateTime> fna_pac { get; set; }
        public string sex_pac { get; set; }
        public string benef_pac { get; set; }
        public string cod_raz { get; set; }
        public string patologia { get; set; }
        public string email_pac { get; set; }
        public string tel_pac { get; set; }
        public string tit_pac { get; set; }
        public Nullable<System.DateTime> exportacion { get; set; }
        public string tipo_doc { get; set; }
        public string fax { get; set; }
        public string cod_prof { get; set; }
        public string cod_aux { get; set; }
        public string usuario_web { get; set; }
        public string password_web { get; set; }
    }
}
