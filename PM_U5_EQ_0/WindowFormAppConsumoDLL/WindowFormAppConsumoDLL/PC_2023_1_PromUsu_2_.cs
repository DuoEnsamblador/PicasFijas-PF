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
    public partial class PC_2023_1_PromUsu_2_ : Form
    {
        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int promUsuario(StringBuilder strRes, string str, int cal1, int cal2, int cal3);

        public PC_2023_1_PromUsu_2_()
        {
            InitializeComponent();
        }

        private void PC_2023_1_PromUsu_2__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            int largo = promUsuario(sb,"Garuco",8,9,7);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
