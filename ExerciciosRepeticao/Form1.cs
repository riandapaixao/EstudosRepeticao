using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LacoFor(object sender, EventArgs e)
        {

            listBoxResultado.Items.Clear();
            
            int inicio = Convert.ToInt32(textBoxInicio.Text);
            int fim = Convert.ToInt32(textBoxFim.Text);

            int i;

            for (i=inicio;i<=fim;i++){
                if (i % 2 == 1){//só irá mostrar os numeros impares / i % 2 == 0 só ira mostrar os pares
                    listBoxResultado.Items.Add(i);
                }
            }
            

        }

        private void WhilePar(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();

            int inicio = Convert.ToInt32(textBoxInicio.Text);
            int fim = Convert.ToInt32(textBoxFim.Text);
            int i;
            
            i = inicio;
            while( i <= fim){
                if (i % 2 == 0)
                {
                    listBoxResultado.Items.Add(i);
                }
                i++;
            }
           
        }

        private void DoWhileTodos(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();

            int inicio = Convert.ToInt32(textBoxInicio.Text);
            int fim = Convert.ToInt32(textBoxFim.Text);
            int i;

            i = inicio;
            
            do{
                listBoxResultado.Items.Add(i);
                i++;
            } while (i <= fim) ;
        }
    }
}
