using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_CYK
{
    class CYK
    {

        /*Metodo doCYK
         *Parametros: 
         *grammar: Recibe la gramatica en una lista de lista de String
         * word: Es la cadena la cual se quiere saber si es generada por la gramatica
         * El metodo retorna true si la cadena es generada por la gramatica, retorna false en caso contrario
         */
        public static Boolean doCYK(List<List<String>> grammar, String word)
        {
            Boolean result = false;
            List<string>[,] matrix = new List<string>[word.Length+1, word.Length+1];
            for (int i = 1, w = 0; i < Math.Sqrt(matrix.Length); i++, w++)
            {
                List<string> X_i_1 = new List<string>();
                foreach (List<String> variableProductions in grammar)
                {
                    for (int j = 1; j < variableProductions.Count; j++)
                    {
                        if ((word.ElementAt(w)+"").Equals(variableProductions.ElementAt(j)))
                        {
                            X_i_1.Add(variableProductions.ElementAt(0));
                        }
                    }
                }
                matrix[i, 1] = X_i_1;
            }

            for (int j = 2; j < Math.Sqrt(matrix.Length); j++)
            {
                for (int i = 1; i <= word.Length-j+1; i++)
                {
                    List<string> X_i_j = new List<string>();
                    for (int k = 1; k <= j - 1; k++)
                    {
                        List<string> aux1 = matrix[i, k];
                        List<string> aux2 = matrix[i + k, j - k];
                        List<string> final = new List<string>();
                        foreach (string variable1 in aux1)
                        {
                            foreach (string variable2 in aux2)
                            {
                                final.Add(variable1 + variable2);
                            }
                        }
                        foreach (string item in final)
                        {
                            X_i_j.Add(item);
                        }
                    }

                    List<string> variables = new List<string>();
                    foreach (string item in X_i_j)
                    {
                        foreach (List<string> variable in grammar)
                        {
                            for (int t = 1; t < variable.Count; t++)
                            {
                                if(item.Equals(variable.ElementAt(t)))
                                {
                                    variables.Add(variable.ElementAt(0));
                                }
                            }
                        }
                    }
                    matrix[i, j] = variables.Distinct().ToList();
                }
            }
            if(matrix[1,word.Length].Contains(grammar.ElementAt(0).ElementAt(0)))
            {
                result = true;
            }

            Resultado vistaResultado = new Resultado();
            vistaResultado.Show();
            vistaResultado.crearMatrizResultado(matrix, word, result);
            
            
            return result;

            
        }
    }
}
