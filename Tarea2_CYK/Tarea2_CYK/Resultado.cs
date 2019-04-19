using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_CYK
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {

        }

        /*Metodo doCYK
         *Parametros: 
         *filasColumnas: Es el numero que me indica el tamaño de la matriz
         * matrix: La matriz de resultados en una lista de strings
         * word: cadena ingresada por el usuario y de la que se quiere saber si es generada por la gramatica
         * result: true si la cadena es generada por la gramatica, retorna false en caso contrario
         * El metodo genera la matriz cuadrada del resultado de CYK dónde se puede apreciar de forma visual si la cadena es o no generada por la gramatica
         */
        public void crearMatrizResultado(List<string>[,] matrix, string word, Boolean result)
        {
            
            for(int i = 1; i <= word.Count(); i++)
            {
                DataGridViewTextBoxColumn cx = new DataGridViewTextBoxColumn();
                cx.ReadOnly = true;
                cx.HeaderText = "J = " + i;
                dgvResultado.Columns.Add(cx);
            }

            for(int i = 1; i <= word.Count(); i++)
            {
                string[] row = new string[word.Count()];
                for(int j = 1; j <= word.Count(); j++)
                {
                    if(matrix[i, j] == null)
                    {
                        row[j - 1] = "";
                    }
                    else
                    {
                        for(int a = 0; a < matrix[i, j].Count; a++)
                        {
                            row[j - 1] = row[j - 1] + matrix[i, j].ElementAt(a) + " ";
                        }
                        
                    }
                    
                }
                dgvResultado.Rows.Add(row);
            }

            if (result)
            {
                lblRespuesta.Text = "La cadena " + word + " es generada por G";
            }
            else
            {
                lblRespuesta.Text = "La cadena " + word + " no es generada por G";
            }
            
        }
    }
}
