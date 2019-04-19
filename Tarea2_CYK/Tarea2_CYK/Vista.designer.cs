using System.Drawing;
using System.Windows.Forms;

namespace Tarea2_CYK
{
    partial class Vista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnRealizarAnalisis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstímulos = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // btnRealizarAnalisis
            // 
            this.btnRealizarAnalisis.Location = new System.Drawing.Point(46, 372);
            this.btnRealizarAnalisis.Name = "btnRealizarAnalisis";
            this.btnRealizarAnalisis.Size = new System.Drawing.Size(269, 35);
            this.btnRealizarAnalisis.TabIndex = 7;
            this.btnRealizarAnalisis.Text = "3. Realizar CYK";
            this.btnRealizarAnalisis.UseVisualStyleBackColor = true;
            this.btnRealizarAnalisis.Click += new System.EventHandler(this.btnRealizarAnalisis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "¡Importante!: Verificar las producciones antes de iniciar el CYK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(46, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Variables";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producciones";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lblEstímulos
            // 
            this.lblEstímulos.AutoSize = true;
            this.lblEstímulos.Location = new System.Drawing.Point(43, 31);
            this.lblEstímulos.Name = "lblEstímulos";
            this.lblEstímulos.Size = new System.Drawing.Size(617, 17);
            this.lblEstímulos.TabIndex = 4;
            this.lblEstímulos.Text = "1. Especificar la gramática: Las producciones deben estar separadas por el caract" +
    "er \'|\' (Ej: AS|b)";
            this.lblEstímulos.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(232, 264);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 22);
            this.txtWord.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "2. Especificar la cadena";
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRealizarAnalisis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEstímulos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finite States Machines Equivalency Tester";
            this.Load += new System.EventHandler(this.Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRealizarAnalisis;
        private System.Windows.Forms.Label label5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lblEstímulos;
        private TextBox txtWord;
        private Label label1;
    }
}