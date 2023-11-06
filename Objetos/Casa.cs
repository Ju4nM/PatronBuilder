using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Objetos {
    public class Casa {
        public int NumeroCuartos { get; set; }
        public int NumeroPuertas { get; set; }
        public int NumeroVentanas { get; set; }
        public bool TieneJardin { get; set; }
        public bool TienePicina { get; set; }

        public Casa() { }
        public Casa(int numeroCuartos, int numeroPuertas, int numeroVentanas, bool tieneJardin, bool tienePicina) {
            NumeroCuartos = numeroCuartos;
            NumeroPuertas = numeroPuertas;
            NumeroVentanas = numeroVentanas;
            TieneJardin = tieneJardin;
            TienePicina = tienePicina;
        }

        override
        public string ToString() {
            return $"Casa {{\n    cantidadDeCuartos: {NumeroCuartos},\n    numeroDePuertas: {NumeroPuertas},\n    cantidadDeVentanas: {NumeroVentanas},\n    tieneJardin: {(TieneJardin ? "si" : "no")},\n    tienePicina: {(TienePicina ? "si" : "no")}\n}}";
        }
    }
}
