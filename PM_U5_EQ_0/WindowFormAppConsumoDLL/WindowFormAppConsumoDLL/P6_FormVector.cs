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
    public partial class P6_FormVector : Form
    {
        //[DllImport(@"D:\FI_Cloud\OneDrive - Universidad Autonoma de Tamaulipas\5_ArchivosCompartidos\PM_2021_1\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]

        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        public static extern IntPtr enviar_arreglo();


        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        public static extern int LiberarMemoria(IntPtr ptr);

        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        public static extern double promedio(int[] arreglo);

        [DllImport(@"C:\Users\AlejandroGarcia\Desktop\PM_0_U5_ProgHibrida\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        public static extern IntPtr asm_prueba(int[] arreglo);


        public P6_FormVector()
        {
            InitializeComponent();
        }

        private void FormVector_Load(object sender, EventArgs e)
        {
            //10.25   ->   1025

            //EJEMPLO 1
            /*
            IntPtr ptr = enviar_arreglo();
            int arrayLength = Marshal.ReadInt32(ptr);
            
            // points to arr[1], which is first value
            IntPtr start = IntPtr.Add(ptr, 4);
            int[] result = new int[arrayLength];
            Marshal.Copy(start, result, 0, arrayLength);

            LiberarMemoria(ptr);

            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show(result[i].ToString());
            }
            ///FIN EJEMPLO 1
            */
            
            //EJEMPLO 2
            /*
            int[] arregloNums = new int[4];
            arregloNums[0] = 10;
            arregloNums[1] = 8;
            arregloNums[2] = 7;
            arregloNums[3] = 9;

            double val = promedio(arregloNums);
            MessageBox.Show(val.ToString());
          */

            
            //EJEMPLO 3
            int[] arregloNums = new int[3];
            arregloNums[0] = 2; // cantidad de elementos que tiene el arreglo
            arregloNums[1] = 6;
            arregloNums[2] = 4;

            for (int i = 0; i < arregloNums.Length; i++)
            {
                MessageBox.Show(arregloNums[i].ToString());
            }

            IntPtr ptr = asm_prueba(arregloNums);
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
