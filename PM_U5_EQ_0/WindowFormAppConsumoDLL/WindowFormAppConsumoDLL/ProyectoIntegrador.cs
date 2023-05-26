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
    public partial class ProyectoIntegrador : Form
    {
        [DllImport(@"C:\Users\Galek\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int valida_num(int[] auxVector);

        [DllImport(@"C:\Users\Galek\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int contar_fijas(int[] num_pc, int[] num_user);
        
        [DllImport(@"C:\Users\Galek\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int contar_picas(int[] num_pc, int[] num_user);

        [DllImport(@"C:\Users\Galek\Desktop\ClasePM_2023_1\PM_2023_ProgsClase\PM_U5_EQ_0\DLL_AppHibrida_ASM_C\Debug\DLL_AppHibrida_ASM_C.dll")]
        static extern int valida_solucion(StringBuilder strRes, int[] num_pc, int[] num_user);

        Random random = new Random();

        public ProyectoIntegrador()
        {
            InitializeComponent();
        }

        int[] nPC;        

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            //Environment.NewLine
            //string msj = string.Join(" ", vector);

            int[] nUser;
            
            try
            {
                int t_digits = nPC.Length;
                nUser = new int[t_digits];
                nUser[0] = t_digits-1;
                char[] temp = txt_num_user.Text.ToCharArray();
                for (int i = 1; i < t_digits; i++)
                {
                    nUser[i] = Convert.ToInt32(temp[i-1])-48;
                }


                
                StringBuilder sb = new StringBuilder(100);                
                int largo = valida_solucion(sb, nPC , nUser);
                string c = sb.ToString();
                c = c.Substring(0, largo);
                //MessageBox.Show(c);


                string msj = " PC: " + string.Join(" ", nPC);
                msj += "  User: " + string.Join(" ", nUser);
                msj += " Result (fijas-picas): " + c;
                MessageBox.Show(msj);
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            };
            

        }

        private int[] genera_aleatorio(int t_digits) { 
            int []num = new int[t_digits + 1];
            num[0] = t_digits;
            for (int i = 1; i < t_digits+1; i++)
            {
                num[i] = random.Next(1,10);
            }
            return num;
        }

        private int[] genera_num(int t_digits) {
            int[] n;
            int esValido;
            do {
                n = genera_aleatorio(t_digits);
                esValido = valida_num(n);
            }
            while (esValido==0);
            return n;
        }

        private void btm_establecer_Click(object sender, EventArgs e)
        {
            int t_digits = Convert.ToInt32(txt_total_digits.Text);

            nPC = genera_num(t_digits);


            string m = string.Join("", nPC);
            string temp = "";
            for (int i = 0; i < t_digits; i++)
            {
                temp += m[i + 1];
            }

            txt_num_pc.Text = temp; 

            btn_jugar.Enabled = true;
            btn_auto_solucion.Enabled = true;
        }

        private void ProyectoIntegrador_Load(object sender, EventArgs e)
        {
            txt_total_digits.Text = "4";
            txt_num_user.Text = "1867";            
            btn_jugar.Enabled = false;
            btn_auto_solucion.Enabled = false;

           
        }

        private int auto_solucion(int[] num_pc)
        {
            int intentos = 0;
            int fijas, picas;
            int t_digits = nPC.Length-1;
            
            do {
                int[] nUser = genera_num(t_digits);

                string m = string.Join(" ", nUser);
                
                
                StringBuilder sb = new StringBuilder(100);
                int largo = valida_solucion(sb, nPC, nUser);
                string res = sb.ToString();
                res = res.Substring(0, largo);

                string []aux = res.Split('-');
                fijas = Convert.ToInt32(aux[0]);
                picas = Convert.ToInt32(aux[1]);

                m += " Picas: " + picas + " Fijas: " + fijas;
                Console.WriteLine(m);

                intentos++;

            }
            while (fijas!=t_digits);
           
            return intentos;

        }

        private void btn_auto_solucion_Click(object sender, EventArgs e)
        {
            int intentos = auto_solucion(nPC);
            MessageBox.Show("Intentos que fueron requeridos: " + intentos);
        }
    }  
}
