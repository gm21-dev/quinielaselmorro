using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quinielas.Class
{
    public class Partido
    {
        public string Local { get; set; } = string.Empty;
        public string Visitante { get; set; } = string.Empty;
        public string Fecha { get; set; } = string.Empty;
        public string Hora { get; set; } = string.Empty;
        public string Votacion { get; set; } = string.Empty;
        public string resultado { get; set; } = string.Empty;
        public string LogoVisitante { get; set; } = string.Empty;
        public string LogoLocal { get; set; } = string.Empty;
    }
}