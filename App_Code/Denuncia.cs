using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DenunciaAPI.App_Code
{
    [Table("REM_DENUNCIA_ANONIMA")]
    public class Denuncia
    {
        [Key]
        public int IdDenunciaAnonima { get; set; }
        public string IdGrupo { get; set; }
        public string IdCadena { get; set; }
        public string IdTienda { get; set; }
        public string IdOperador { get; set; }
        public string LugarHechos { get; set; }
        public string FechaSuceso { get; set; }
        public string NombreInvolucrado { get; set; }
        public bool TrabajaDatransfer { get; set; }
        public string PrioridadDenuncia { get; set; }
        public string TipoDenuncia { get; set; }
        public string Hechos { get; set; }
        public int IdInvestigacion { get; set; }
    }
}
