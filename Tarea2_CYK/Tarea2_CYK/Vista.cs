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
    public partial class Vista : Form
    {
        /// <summary>
        /// Inicializa la interfaz gráfica
        /// </summary>
        public Vista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void agregarFila_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;

        }
        /// <summary>
        /// Permite inicializar las tablas de las máquinas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inicializarTablas_Click(object sender, EventArgs e)
        {
            this.dataGridView1 = new DataGridView();

            DataGridViewTextBoxColumn[] columnasgrid1 = new DataGridViewTextBoxColumn[2];

            columnasgrid1[0] = new DataGridViewTextBoxColumn();
            columnasgrid1[0].HeaderText = "Variables";
            columnasgrid1[0].Name = "Variables";

            columnasgrid1[1] = new DataGridViewTextBoxColumn();
            columnasgrid1[1].HeaderText = "Producciones";
            columnasgrid1[1].Name = "Producciones";


            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView1.Columns.AddRange(columnasgrid1);
            this.dataGridView1.Location = new System.Drawing.Point(20, 170);
            this.dataGridView1.Size = new Size(500, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
            this.dataGridView1.AllowUserToOrderColumns = false;
            this.Controls.Add(this.dataGridView1);
            this.dataGridView1.AutoResizeColumns();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Vista_Load(object sender, EventArgs e)
        {

        }
        
        private void btnRealizarAnalisis_Click(object sender, EventArgs e)
        {
            List<List<string>> grammar = new List<List<string>>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<string> variable = new List<string>();
                List<string> aux = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    aux.Add(cell.Value + "");
                }
                variable.Add(aux.ElementAt(0));
                foreach (string production in aux.ElementAt(1).Split('|'))
                {
                    variable.Add(production);
                }
                grammar.Add(variable);
            }
            grammar.Remove(grammar.Last());
            CYK.doCYK(grammar, txtWord.Text);

        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
