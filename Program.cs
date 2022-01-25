using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esbocoProjeto2
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginesenha logar = new loginesenha();
            if (logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMenu());
            }


        }
    }
}
