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
    public partial class Pc2023_1_Fibunacci : Form
    {
        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int fibunacci(int t0, int t1);

        public Pc2023_1_Fibunacci()
        {
            InitializeComponent();
        }

        private void Pc2023_1_Fibunacci_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int t0 = int.Parse(txtT0.Text);
            int t1 = int.Parse(txtT1.Text);

            int tn = 0;
            String serie = $"{t0} - {t1} - ";
            for (int i = 0; i < 8; i++)
            {
                tn = fibunacci(t0, t1);
                serie += $"{tn} - ";
                t0 = t1;
                t1 = tn;
            }

            MessageBox.Show($"Serie Fibunacci: {serie}", "Serie Fibunacci");
        }
    }
}
