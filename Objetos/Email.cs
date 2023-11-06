using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Objetos {
    public class Email {
        public string Remitente { get; set; }
        public string Destinatario { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public bool TieneAdjuntos { get; set; }
        public string TipoArchivo { get; set; }

        public Email (string remitente, string destinatario, string asunto, string cuerpo, bool tieneAdjuntos, string tipoArchivo) {
            Remitente = remitente;
            Destinatario = destinatario;
            Asunto = asunto;
            Cuerpo = cuerpo;
            TieneAdjuntos = tieneAdjuntos;
            TipoArchivo = tipoArchivo;
        }

        public Email () { }

        override
        public string ToString () {
            return $"Email {{\n    remitente: {Remitente},\n    destinatario: {Destinatario},\n    asunto: {Asunto},\n    cuerpo: {Cuerpo},\n    tieneAdjuntos: {(TieneAdjuntos ? "si" : "no")},\n    tipoArchivo: {TipoArchivo}\n}}";
        }
    }
}
