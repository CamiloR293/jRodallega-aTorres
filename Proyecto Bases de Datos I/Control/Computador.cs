using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bases_de_Datos_I.Control
{
    internal class Computador
    {
        private long serial;
        private string marca;
        private int capacidad;
        private string tipoDisco;

        public Computador()
        {
        }

        public Computador(long serial, string marca, int capacidad, string tipoDisco)
        {
            this.serial = serial;
            this.marca = marca;
            this.capacidad = capacidad;
            this.tipoDisco = tipoDisco;
        }

        public long getSerial()
        {
            return serial;
        }
        public void setSerial(long serial)
        {
            this.serial = serial;
        }

        public string getMarca()
        {
            return marca;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public int getCapacidad()
        {
            return capacidad;
        }
        public void setCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public string getTipoDisco()
        {
            return tipoDisco;
        }
        public void setTipoDisco(string tipoDisco)
        {
            this.tipoDisco = tipoDisco;
        }


    }
}
