namespace Proyecto_Bases_de_Datos_I
{
    internal static class Program
    {

        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }
    }
}