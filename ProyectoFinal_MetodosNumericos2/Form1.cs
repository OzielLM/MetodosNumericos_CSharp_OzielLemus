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
    public partial class frmNR : Form
    {
        public frmNR()
        {
            InitializeComponent();
        }

        double[] gxi;
        int i;
        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            double ea;
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double d = double.Parse(txtD.Text);
            double xi = double.Parse(txtXi.Text);

            gxi = new double[100000000];
            i = 0;

            lstResultados.Items.Add("i\t" + "Xi\t" + "g(XI)");

            do
            {
                gxi[i] = Math.Round(xi - (((a * Math.Pow(xi, 3)) + (b * Math.Pow(xi, 2)) + (c * xi) + d) / ((3 * a * Math.Pow(xi, 2)) + (2 * b * xi) + c)), 4);

                lstResultados.Items.Add(i + "\t" + xi + "\t" + gxi[i]);

                xi = gxi[i];

                if (i == 0)
                {
                    ea = gxi[i];
                }
                else
                {
                    ea = Math.Abs(gxi[i] - gxi[i - 1]);
                }

                i++;
            } while (ea > 0.001);
            MessageBox.Show($"El resultado es {gxi[i - 1]}");
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            graficoNR.Series[0].Points.Clear();
            for (int j = 0; j < i; j++)
            {
                graficoNR.Series[0].Points.Add(gxi[j]);
            }
        }

        private void bisecciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form B = new frmBisección();
            B.Show();
            this.Hide();
        }

        private void polinomiosDeLagrengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PL = new frmLagrenge();
            PL.Show();
            this.Hide();
        }

        private void minimosCuadradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MC = new frmMC();
            MC.Show();
            this.Hide();
        }

        private void rungeKuttaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RK = new frmRK();
            RK.Show();
            this.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
