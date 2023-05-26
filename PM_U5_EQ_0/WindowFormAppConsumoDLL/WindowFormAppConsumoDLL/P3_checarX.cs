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
    public partial class P3_checarX : Form
    {
        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int ChecarX(int X, int Z, int Y);

        public P3_checarX()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(txt_X.Text);
            int Z = Convert.ToInt32(txt_Z.Text);
            int Y = Convert.ToInt32(txt_Y.Text);

            int resultado = ChecarX(X, Z, Y);

            string r = resultado == 0 ? "No esta en el intervalo" : "Esta en el intervalo";

            txt_resultado.Text = r;

        }
    }
}
