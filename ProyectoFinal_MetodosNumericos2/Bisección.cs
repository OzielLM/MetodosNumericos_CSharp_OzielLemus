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
    public partial class frmBisección : Form
    {
        public frmBisección()
        {
            InitializeComponent();
        }

        int n;
        double[] xm;
        int i;
        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            double ea;
            double a = int.Parse(txtA.Text);
            double b = int.Parse(txtB.Text);
            double c = int.Parse(txtC.Text);
            double d = int.Parse(txtD.Text);


            double Xi = double.Parse(txtXi.Text);
            double Xd = double.Parse(txtXd.Text);

            n = (int)((Math.Log(Xd - Xi) - Math.Log(0.001)) / Math.Log(2));
            xm = new double[n + 1];
            i = 0;

            do
            {
                xm[i] = Math.Round((Xi + Xd) / 2, 4);

                double fx = Math.Round((a * Math.Pow(xm[i], 3)) + (b * Math.Pow(xm[i], 2)) + (c * xm[i]) + d, 4);

                if (fx < 0)
                {
                    Xi = xm[i];
                }
                else
                {
                    Xd = xm[i];
                }

                if (i == 0)
                {
                    ea = xm[i];
                }
                else
                {
                    ea = Math.Abs(xm[i] - xm[i - 1]);
                }

                i++;
            } while (ea > 0.001);

            for (int i = 0; i < n; i++)
            {
                lstResultados.Items.Add($"En la Iteración {i + 1}: Xm= {xm[i]}");
            }
            MessageBox.Show($"El resultado es {xm[n - 1]}");
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            graficoB.Series[0].Points.Clear();
            for (int i = 0; i < n; i++)
            {
                graficoB.Series[0].Points.Add(xm[i]);
            }
        }

        private void newtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NR = new frmNR();
            NR.Show();
            this.Close();
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

        private void rungeKuttaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RK = new frmRK();
            RK.Show();
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
