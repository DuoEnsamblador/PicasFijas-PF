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
    public partial class P5_FormCadena : Form
    {
        
        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int largo_cadena(string str);

        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int escribir_cadena(StringBuilder str, int len_buffer);


        public P5_FormCadena()
        {
            InitializeComponent();
        }

        private void P5_FormCadena_Load(object sender, EventArgs e)
        {
            //EJEMPLO 1
           // int len = largo_cadena("JUAN@@@@@CARLOS");
           // MessageBox.Show("Largo: " + len);

            //EJEMPLO 2
            
            try
            {
                StringBuilder sb = new StringBuilder(20);
                int largo = escribir_cadena(sb, sb.Capacity);
                string c = sb.ToString();
                c = c.Substring(0, largo);
                MessageBox.Show(c);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            this.Close();
            
        }
    }
}
