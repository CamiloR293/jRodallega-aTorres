namespace Proyecto_Bases_de_Datos_I.Control
{
    internal class Empresa
    {
        private long nitEmpresa;
        private string nombreEmpresa;
        public Empresa()
        {
        }

        public Empresa(long nitEmpresa, string nombreEmpresa)
        {
            this.nitEmpresa = nitEmpresa;
            this.nombreEmpresa = nombreEmpresa;
        }

        public long getNitEmpresa()
        {
            return nitEmpresa;
        }
        public void setNitEmpresa(long nitEmpresa)
        {
            this.nitEmpresa = nitEmpresa;
        }

        public string getNombreEmpresa()
        {
            return nombreEmpresa;
        }
        public void setNombreEmpresa(string nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;
        }

    }
}
