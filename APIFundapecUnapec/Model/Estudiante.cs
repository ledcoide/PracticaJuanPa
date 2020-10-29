using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIFundapecUnapec.Model
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string CrdTotal { get; set; }
        public string CrdtCursados { get; set; }
    }
}
