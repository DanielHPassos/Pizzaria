using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        public int cd_Cliente { get; set; }
        public string nm_Cliente { get; set; }
        public string ds_Endereco { get; set; }
        public DateTime dt_Nascimento { get; set; }
        public string cd_TelResidencial { get; set; }
        public string cd_TelCelular { get; set; }

    }
}
