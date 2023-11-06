using PatronBuilder.Constructores;
using PatronBuilder.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Interfaces {
    public interface IEmailBuilder {

        public EmailBuilder SetRemitente (string remitente);
        public EmailBuilder SetDestinatario (string destinatario);
        public EmailBuilder SetAsunto(string asunto);
        public EmailBuilder SetCuerpo(string cuerpo);
        public EmailBuilder SetTieneAdjuntos(bool tieneAdjuntos);
        public EmailBuilder SetTipoArchivo(string tipo);

        public Email Build();
    }
}
