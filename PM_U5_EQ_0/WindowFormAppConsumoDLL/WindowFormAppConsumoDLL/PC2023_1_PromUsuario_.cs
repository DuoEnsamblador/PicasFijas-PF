using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormAppConsumoDLL
{
    public partial class PC2023_1_PromUsuario_ : Form
    {
        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int promedioDeUsuario(string str, int cal1, int cal2, int cal3);

        public PC2023_1_PromUsuario_()
        {
            InitializeComponent();
        }

        private void PC2023_1_PromUsuario__Load(object sender, EventArgs e)
        {
            string nombre;
            int cal1;
            int cal2;
            int cal3;

            nombre = "Secuestrador";
            cal1 = 8;
            cal2 = 9;
            cal3 = 7;

            int resultado = promedioDeUsuario(nombre, cal1, cal2, cal3);

            MessageBox.Show(nombre +" Tiene un Promedio de: "+ resultado.ToString());
        }
    }
}
