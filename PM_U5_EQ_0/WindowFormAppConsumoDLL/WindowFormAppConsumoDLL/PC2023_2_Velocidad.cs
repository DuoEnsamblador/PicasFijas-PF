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
    public partial class PC2023_2_Velocidad : Form
    {
        [DllImport(@"C:\Users\Galek\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int velocidad(StringBuilder strRes, string str, int distancia, int tiempo);


        public PC2023_2_Velocidad()
        {
            InitializeComponent();
        }

        StringBuilder sb;
        private void PC2023_2_Velocidad_Load(object sender, EventArgs e)
        {
            sb = new StringBuilder(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sb.Clear();
            int largo = velocidad(sb, "Coche Azulito", 120, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);

        }
    }
}
