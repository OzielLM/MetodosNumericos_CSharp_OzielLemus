using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_MetodosNumericos2
{
    public partial class frmRK : Form
    {
        public frmRK()
        {
            InitializeComponent();
        }

        double[] y;
        int i;
        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            double ix = double.Parse(txtiX.Text);
            double iy = double.Parse(txtiY.Text);
            double aprx = double.Parse(txtAprox.Text);
            double h = double.Parse(txth.Text);

            y = new double[1000];
            i = 0;

            double k1;
            double k2;
            double k3;
            double k4;
            double x=0;
            double yi;

            lstResultados.Items.Add("i\t ix\t iy\t k1\t k2\t k3\t k4\t y");

            do
            {
                if (i == 0)
                {
                    k1 = ix - iy;
                    k2 = Math.Round((ix + (h / 2)) - (iy + ((h / 2) * k1)), 4);
                    k3 = Math.Round((ix + (h / 2)) - (iy + ((h / 2) * k2)), 4);
                    k4 = Math.Round((ix + h) - (iy + (h * k3)), 4);
                    yi = Math.Round(iy + (h / 6 * (k1 + 2 * k2 + 2 * k3 + k4)),4);
                    y[i] = yi;
                    lstResultados.Items.Add($"{i}\t {ix}\t {iy}\t {k1}\t {k2}\t {k3}\t {k4}\t {yi}");
                    iy = yi;
                }
                else
                {
                    x = ix + h;
                    k1 = x - iy;
                    k2 = Math.Round((x + (h / 2)) - (iy + ((h / 2) * k1)), 4);
                    k3 = Math.Round((x + (h / 2)) - (iy + ((h / 2) * k2)), 4);
                    k4 = Math.Round((x + h) - (iy + (h * k3)), 4);
                    yi = Math.Round(iy + (h / 6 * (k1 + 2 * k2 + 2 * k3 + k4)),4);
                    y[i] = yi;
                    lstResultados.Items.Add($"{i}\t {x}\t {iy}\t {k1}\t {k2}\t {k3}\t {k4}\t {yi}");
                    ix = x;
                    iy = yi;
                }
                i++;
            } while (x<aprx);
            MessageBox.Show($"El resultado es {y[i-1]}");
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            graficoRK.Series[0].Points.Clear();
            for (int j = 0; j < i; j++)
            {
                graficoRK.Series[0].Points.Add(y[j]);
            }
        }

        private void newtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NR = new frmNR();
            NR.Show();
            this.Close();
        }

        private void bisecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form B = new frmBisección();
            B.Show();
            this.Hide();
        }

        private void polinomiosDeLagrengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PL = new frmLagrenge();
            PL.Show();
            this.Close();
        }

        private void minimosCuadradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MC = new frmMC();
            MC.Show();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
