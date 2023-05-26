using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormAppConsumoDLL
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new P0_OpArtimeticas());
            //Application.Run(new P1_puedoVotar());
            //Application.Run(new P2_discriminante());
            //Application.Run(new P3_checarX());
            //Application.Run(new P4_SumaConsecutiva());

            //Application.Run(new P5_FormCadena());

            //Application.Run(new P6_FormVector());

            // Application.Run(new PC2023_1_PromUsuario_());

            //Application.Run(new PC_2023_1_PromUsu_2_());

            //Application.Run(new Pc2023_1_Fibunacci());

            //Application.Run(new PC2023_2_Velocidad());

            //Application.Run(new PC_2023_1_ComparaNumeros());

            Application.Run(new ProyectoIntegrador());

        }
    }
}
