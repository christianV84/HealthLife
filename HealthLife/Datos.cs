using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthLife
{
    internal class Datos
    {
        public int digitalDni,digitalBuscar;
        public string digitalNombre;
        public string digitalApellido;
        public int digitalNumhistoria;
        public string digitalEspecialidad;
        public string digitalMedico;
        public string digitalFecha;
        public int digitalPrecio;
        public Datos digitalSiguiente;
        public Datos digitalAnterior;

        public Datos(int digitalid, string digitalnom, string digitalape, int digitalnumhis,
            string digitalespe, string digitalmed, string digitalfec,int digitalPre, Datos digitalsi, Datos digitalant)
        {
            digitalDni = digitalid;
            digitalNombre = digitalnom;
            digitalApellido = digitalape;
            digitalNumhistoria = digitalnumhis;
            digitalEspecialidad = digitalespe;
            digitalMedico = digitalmed;
            digitalFecha = digitalfec;
            digitalPrecio = digitalPre;
            digitalSiguiente = digitalsi;
            digitalAnterior = digitalant;
            digitalBuscar = digitalid;
        }

    }
}
