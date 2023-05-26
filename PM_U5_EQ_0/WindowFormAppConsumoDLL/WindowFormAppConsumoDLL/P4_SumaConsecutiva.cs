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
    //"D:\FI_Cloud\OneDrive - Universidad Autonoma de Tamaulipas\5_ArchivosCompartidos\PM_2021_1\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll"

    public partial class P4_SumaConsecutiva : Form
    {
        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int SumaDosNumeros(int P1, int P2);


        public P4_SumaConsecutiva()
        {
            InitializeComponent();
        }

        private void SumaConsecutiva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txt_A.Text);
            int B = Convert.ToInt32(txt_B.Text);
            int C = Convert.ToInt32(txt_C.Text);

            int AUX = SumaDosNumeros(A, B);
            int resultado = SumaDosNumeros(C, AUX);

            txt_resultado.Text = resultado.ToString();

        }
    }
}
