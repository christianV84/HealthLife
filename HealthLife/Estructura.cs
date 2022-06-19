using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthLife
{
    internal class Estructura
    {
        Datos digitalPrimero, digitalUltimo;

        public void insertar(int digitalid, string digitalnom, string digitalape, int digitalnumhis,
            string digitalespe, string digitalmed, string digitalfec, int digitalPre)
        {
            Datos p = new Datos(digitalid, digitalnom, digitalape, digitalnumhis, digitalespe, digitalmed, digitalfec, digitalPre, digitalPrimero, digitalUltimo);
            p.digitalDni = digitalid;
            p.digitalNombre = digitalnom;
            p.digitalApellido = digitalape;
            p.digitalNumhistoria = digitalnumhis;
            p.digitalEspecialidad = digitalespe;
            p.digitalMedico = digitalmed;
            p.digitalFecha = digitalfec;
            p.digitalPrecio = digitalPre;
            p.digitalBuscar = digitalid;



            if (digitalPrimero == null)
            {
                digitalPrimero = p;
                digitalPrimero.digitalAnterior = null;
                digitalPrimero.digitalSiguiente = null;
                digitalUltimo = digitalPrimero;
            }
            else 
            {
                digitalUltimo.digitalSiguiente = p;
                p.digitalSiguiente = null;
                p.digitalAnterior = digitalUltimo;
                digitalUltimo = p;
            }

        }

        public void mostrar(RichTextBox text)
        {
            Datos digitalActual;
            digitalActual = digitalPrimero;

            text.Clear();
            while (digitalActual != null)
            {

                text.Text += digitalActual.digitalDni.ToString() + " - "
                    + digitalActual.digitalNombre.ToString() + " - "
                    + digitalActual.digitalApellido.ToString() + " - "
                    + digitalActual.digitalNumhistoria.ToString() + " - "
                    + digitalActual.digitalEspecialidad.ToString() + " - "
                    + digitalActual.digitalMedico.ToString() + " - "
                    + digitalActual.digitalPrecio.ToString() + " soles - "
                    + digitalActual.digitalFecha.ToString() + Environment.NewLine;

                digitalActual = digitalActual.digitalSiguiente;

            }

        }


        public void buscard(int valor)
        {

            Datos actual;
            actual = digitalPrimero;
            bool f = false;
            while (actual != null && f == false)
            {
                if (actual.digitalDni == valor)
                {

                    f = true;

                }

                actual = actual.digitalSiguiente;

            }
            if (f == true)
            {
                MessageBox.Show(valor + "  Paciente encontrado", "Bicola", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(valor + "  No se encuentra el Paciente con este numero de DNI", "Bicola", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
        public void buscarh(int valor)
        {
            Datos actual;
            actual = digitalPrimero;
            bool f = false;
            while (actual != null && f == false)
            {
                if (actual.digitalNumhistoria == valor)
                {

                    f = true;

                }

                actual = actual.digitalSiguiente;

            }
            if (f == true)
            {
                MessageBox.Show(valor + "  Paciente encontrado", "Bicola", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(valor + "  No se encuentra el Paciente con este N° de Historia", "Bicola", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        public void clasificarMedicinaGeneral(RichTextBox text)
        {
            Datos digitalActual;
            Datos digitalActual1;
            digitalActual = digitalPrimero;
            digitalActual1 = digitalUltimo;

            text.Clear();

            while (digitalActual != null && digitalActual.digitalEspecialidad == "Medicina General")
            {
                text.Text += digitalActual.digitalDni.ToString() + " - "
                    + digitalActual.digitalNombre.ToString() + " - "
                    + digitalActual.digitalApellido.ToString() + " - "
                    + digitalActual.digitalNumhistoria.ToString() + " - "
                    + digitalActual.digitalEspecialidad.ToString() + " - "
                    + digitalActual.digitalMedico.ToString() + " - "
                    + digitalActual.digitalPrecio.ToString() + " soles - "
                    + digitalActual.digitalFecha.ToString() + Environment.NewLine;

                digitalActual = digitalActual.digitalSiguiente;
            }

            while (digitalActual1 != null && digitalActual1.digitalEspecialidad == "Medicina General")
            {
                text.Text += digitalActual1.digitalDni.ToString() + " - "
                    + digitalActual1.digitalNombre.ToString() + " - "
                    + digitalActual1.digitalApellido.ToString() + " - "
                    + digitalActual1.digitalNumhistoria.ToString() + " - "
                    + digitalActual1.digitalEspecialidad.ToString() + " - "
                    + digitalActual1.digitalMedico.ToString() + " - "
                    + digitalActual1.digitalPrecio.ToString() + " soles - "
                    + digitalActual1.digitalFecha.ToString() + Environment.NewLine;

                digitalActual1 = digitalActual1.digitalAnterior;
            }
        }

        public void clasificarNutricion(RichTextBox text)
        {
            Datos digitalActual;
            Datos digitalActual2;
            digitalActual = digitalPrimero;
            digitalActual2 = digitalUltimo;

            text.Clear();
            while (digitalActual != null && digitalActual.digitalEspecialidad == "Nutricion")
            {
                text.Text += digitalActual.digitalDni.ToString() + " - "
                    + digitalActual.digitalNombre.ToString() + " - "
                    + digitalActual.digitalApellido.ToString() + " - "
                    + digitalActual.digitalNumhistoria.ToString() + " - "
                    + digitalActual.digitalEspecialidad.ToString() + " - "
                    + digitalActual.digitalMedico.ToString() + " - "
                    + digitalActual.digitalPrecio.ToString() + " soles - "
                    + digitalActual.digitalFecha.ToString() + Environment.NewLine;

                digitalActual = digitalActual.digitalSiguiente;
            }

            while (digitalActual2 != null && digitalActual2.digitalEspecialidad == "Nutricion")
            {
                text.Text += digitalActual2.digitalDni.ToString() + " - "
                    + digitalActual2.digitalNombre.ToString() + " - "
                    + digitalActual2.digitalApellido.ToString() + " - "
                    + digitalActual2.digitalNumhistoria.ToString() + " - "
                    + digitalActual2.digitalEspecialidad.ToString() + " - "
                    + digitalActual2.digitalMedico.ToString() + " - "
                    + digitalActual2.digitalPrecio.ToString() + " soles - "
                    + digitalActual2.digitalFecha.ToString() + Environment.NewLine;

                digitalActual2 = digitalActual2.digitalAnterior;
            }
        }

        public void ordenarAscendente()
        {
            int t = 1, c = 1;
            Datos actual = digitalPrimero;
            while (actual.digitalSiguiente != null)
            {
                actual = actual.digitalSiguiente;
                c++;
            }

            int tem = 0;
            string tem1;
            string tem2;
            string tem3;

            do
            {
                actual = digitalPrimero;
                Datos sig = actual.digitalSiguiente;
                while (actual.digitalSiguiente != null)
                {
                    if (actual.digitalNumhistoria > sig.digitalNumhistoria)
                    {
                        tem = actual.digitalNumhistoria;
                        actual.digitalNumhistoria = sig.digitalNumhistoria;
                        sig.digitalNumhistoria = tem;

                        tem1 = actual.digitalNombre;
                        actual.digitalNombre = sig.digitalNombre;
                        sig.digitalNombre = tem1;

                        tem2 = actual.digitalApellido;
                        actual.digitalApellido = sig.digitalApellido;
                        sig.digitalApellido = tem2;

                        tem3 = actual.digitalEspecialidad;
                        actual.digitalEspecialidad = sig.digitalEspecialidad;
                        sig.digitalEspecialidad = tem3;

                        actual = actual.digitalSiguiente;
                        sig = sig.digitalSiguiente;
                    }
                    else
                    {
                        actual = actual.digitalSiguiente;
                        sig = sig.digitalSiguiente;
                    }
                }
                t++;

            } while (t <= c);
        }

        public void mostrar1(RichTextBox text)
        {
            Datos digitalActual;
            digitalActual = digitalPrimero;

            text.Clear();
            while (digitalActual != null)
            {

                text.Text += digitalActual.digitalNumhistoria.ToString() + " - "
                    + digitalActual.digitalNombre.ToString() + " - "
                    + digitalActual.digitalApellido.ToString() + " - "
                    + digitalActual.digitalEspecialidad.ToString() + " - " +  Environment.NewLine;

                digitalActual = digitalActual.digitalSiguiente;

            }

        }

        public void conteoGeneral()
        {
            Datos actual ;
            actual = digitalPrimero;

            int n = 0;

            while (actual != null)
            {
                actual = actual.digitalSiguiente;
                n++;
            }

            if (n > 0)
            {
                MessageBox.Show($"hay un total de {n} pacientes");
            }
            else
            {
                MessageBox.Show("No hay pacientes registrados");
            }
        }

        public void conteoMedicinaGeneral()
        {
            Datos digitalActual;
            Datos digitalActual1;
            digitalActual = digitalPrimero;
            digitalActual1 = digitalUltimo;

            int n = 0;
            int m = 0;
            
            while (digitalActual != null && digitalActual.digitalEspecialidad == "Medicina General")
            {
                digitalActual = digitalActual.digitalSiguiente;
                n++;
            }

            while (digitalActual1 != null && digitalActual1.digitalEspecialidad == "Medicina General")
            {
                digitalActual1 = digitalActual1.digitalAnterior;
                m++;
            }


            if (n+m > 0)
            {
                MessageBox.Show($"la especialidad de Medicina General tiene {n+m} pacientes");
            }
            else
            {
                MessageBox.Show("No hay pacientes en esta especialidad");
            }
        }

        public void conteoNutricion()
        {
            Datos digitalActual;
            Datos digitalActual1;
            digitalActual = digitalPrimero;
            digitalActual1 = digitalUltimo;

            int n = 0;
            int m = 0;

            while (digitalActual != null && digitalActual.digitalEspecialidad == "Nutricion")
            {
                digitalActual = digitalActual.digitalSiguiente;
                n++;
            }

            while (digitalActual1 != null && digitalActual1.digitalEspecialidad == "Nutricion")
            {
                digitalActual1 = digitalActual1.digitalAnterior;
                m++;
            }


            if (n + m > 0)
            {
                MessageBox.Show($"la especialidad de Nuricion tiene {n + m} pacientes");
            }
            else
            {
                MessageBox.Show("No hay pacientes en esta especialidad");
            }
        }


        public void conteoDineroGeneral()
        {
            Datos actual;
            actual = digitalPrimero;

            int n = 0;

            while (actual != null)
            {
                actual = actual.digitalSiguiente;
                n++;
            }

            if (n > 0)
            {
                MessageBox.Show($"Se recaudo un total de {30 * n} soles");
            }
            else
            {
                MessageBox.Show("No se reacudo nada en este turno");
            }
        }

        public void conteoDineroMedicinaGeneral()
        {
            Datos digitalActual;
            Datos digitalActual1;
            digitalActual = digitalPrimero;
            digitalActual1 = digitalUltimo;

            int n = 0;
            int m = 0;

            while (digitalActual != null && digitalActual.digitalEspecialidad == "Medicina General")
            {
                digitalActual = digitalActual.digitalSiguiente;
                n++;
            }

            while (digitalActual1 != null && digitalActual1.digitalEspecialidad == "Medicina General")
            {
                digitalActual1 = digitalActual1.digitalAnterior;
                m++;
            }


            if (n + m > 0)
            {
                MessageBox.Show($"Se recaudo un total de  {30 * (n + m)} soles en Medicina General");
            }
            else
            {
                MessageBox.Show("No se recaudo nada en esta especialidad");
            }
        }

        public void conteoDineroNutricion()
        {
            Datos digitalActual;
            Datos digitalActual1;
            digitalActual = digitalPrimero;
            digitalActual1 = digitalUltimo;

            int n = 0;
            int m = 0;

            while (digitalActual != null && digitalActual.digitalEspecialidad == "Nutricion")
            {
                digitalActual = digitalActual.digitalSiguiente;
                n++;
            }

            while (digitalActual1 != null && digitalActual1.digitalEspecialidad == "Nutricion")
            {
                digitalActual1 = digitalActual1.digitalAnterior;
                m++;
            }


            if (n + m > 0)
            {
                MessageBox.Show($"Se recaudo un total de  {30 * (n + m)} soles en Nutricion");
            }
            else
            {
                MessageBox.Show("No se recaudo nada en esta especialidad");
            }
        }
    }
}
