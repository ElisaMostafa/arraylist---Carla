using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arraylistt
{
    public partial class Form1 : Form
    {
        ArrayList tarefa = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tarefa.Contains(textBox1.Text)) // método contains = verifica se o valor existe na lista
            {
                MessageBox.Show("A tarefa já existe na lista");
            }
            else
            {
                
                MessageBox.Show("Tarefa cadastrada!");
                tarefa.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var x in tarefa) //forech se usa quando nao se sabe a quantidade de repetições
                                    //var x vai guardar os dados do array func
            {
                tarefas.Items.Add(x);
                // pra adicionar na list box 

            }
            
            qntdtarefas.Items.Add(tarefa.Count);


        }
    }
}
