using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasWorker
{
    public partial class Form1 : Form
    {
        int suma = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hacercosaseasy();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            HacercosasNoVariables(Convert.ToInt32(numericUpDown1.Value));
        }
        public void HacercosasNoVariables(int entrada)
        {
            for (int i = 0; i < 999999999; i++)
            {
                suma += i;
            }
        }
        public void Hacercosaseasy()
        {
            int n = 20;
            List<string> algo = new List<string>();
            for (int i = 0; i < n; i++)
            {
                algo.Add("cad"+i.ToString());
            }
            foreach (string item in algo)
            {
                richTextBox1.Text += "Esto no es asincrono "+item;
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox2.Text = "El subproceso ha terminado exitosamente pe: "+suma.ToString();
        }
    }
}
