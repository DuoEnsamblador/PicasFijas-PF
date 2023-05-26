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
    public partial class PC_2023_1_ComparaNumeros : Form
    {
        [DllImport(@"C:\Users\Galek\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern IntPtr comparaNumeros(StringBuilder strRes, string str, int[] auxVector1);

        //public static extern IntPtr asm_prueba(int[] arreglo);


        public PC_2023_1_ComparaNumeros()
        {
            InitializeComponent();
        }

        StringBuilder sb;

        private void PC_2023_1_ComparaNumeros_Load(object sender, EventArgs e)
        {

            /*
            int largo = comparaNumeros(sb, "Coche Azulito", 50, 59,4);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);*/

            sb = new StringBuilder(100);
            sb.Clear();

            int[] arregloNums = new int[6];
            arregloNums[0] = 5; // cantidad de elementos que tiene el arreglo
            arregloNums[1] = 10; //para obtener la longitud de la cadena de resultado 
            arregloNums[2] = 10;  //decimal 1
            arregloNums[3] = 3;  //decumal 2
            arregloNums[4] = 7;  //decimal 3
            arregloNums[5] = 8;  //decimal 4
            
            IntPtr ptr = comparaNumeros(sb, "Hola :D",arregloNums);
            int arrayLength = Marshal.ReadInt32(ptr);

            // points to arr[1], which is first value
            IntPtr start = IntPtr.Add(ptr, 4);
            int[] result = new int[arrayLength];
            Marshal.Copy(start, result, 0, arrayLength);

            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show(result[i].ToString());
            }
        }
    }
}
