using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronBuilder.Interfaces;
using PatronBuilder.Objetos;

namespace PatronBuilder.Constructores {
    public class EmailBuilder : IEmailBuilder {
        private Email email = new Email();
        public Email Build() {
            return email;
        }

        public EmailBuilder SetAsunto(string asunto) {
            email.Asunto = asunto;
            return this;
        }

        public EmailBuilder SetCuerpo(string cuerpo) {
            email.Cuerpo = cuerpo;
            return this;
        }

        public EmailBuilder SetDestinatario(string destinatario) {
            email.Destinatario = destinatario;
            return this;
        }

        public EmailBuilder SetRemitente(string remitente) {
            email.Remitente = remitente;
            return this;
        }

        public EmailBuilder SetTieneAdjuntos(bool tieneAdjuntos) {
            email.TieneAdjuntos = tieneAdjuntos;
            if (!tieneAdjuntos) email.TipoArchivo = "Ninguno";
            return this;
        }

        public EmailBuilder SetTipoArchivo(string tipo) {
            email.TipoArchivo = tipo;           
            if (tipo != "") email.TieneAdjuntos = true;
            return this;
        }
    }
}
