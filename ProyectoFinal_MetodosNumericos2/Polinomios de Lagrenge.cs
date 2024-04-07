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
    public partial class frmLagrenge : Form
    {
        public frmLagrenge()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        double d;
        private void btnResultados_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txtX0.Text);
            double x1 = Convert.ToDouble(txtX1.Text);
            double x2 = Convert.ToDouble(txtX2.Text);
            double x3 = Convert.ToDouble(txtX3.Text);


            double Fxi0 = Convert.ToDouble(txtFxi0.Text);
            double Fxi1 = Convert.ToDouble(txtFxi1.Text);
            double Fxi2 = Convert.ToDouble(txtFxi2.Text);
            double Fxi3 = Convert.ToDouble(txtFxi3.Text);


            double ax0 = Fxi0 / ((x0 - x1) * (x0 - x2) * (x0 - x3));
            double ax1 = Fxi1 / ((x1 - x0) * (x1 - x2) * (x1 - x3));
            double ax2 = Fxi2 / ((x2 - x0) * (x2 - x1) * (x2 - x3));
            double ax3 = Fxi3 / ((x3 - x0) * (x3 - x1) * (x3 - x2));


            double bx0 = +-(ax0) * (x1 + x2 + x3);
            double bx1 = +-(ax1) * (x0 + x2 + x3);
            double bx2 = +-(ax2) * (x0 + x1 + x3);
            double bx3 = +-(ax3) * (x0 + x1 + x2);


            double cx0 = (ax0) * (x1 * x2 + x1 * x3 + x2 * x3);
            double cx1 = (ax1) * (x0 * x2 + x0 * x3 + x2 * x3);
            double cx2 = (ax2) * (x0 * x1 + x0 * x3 + x1 * x3);
            double cx3 = (ax3) * (x0 * x1 + x0 * x2 + x1 * x2);


            double d0 = +-(ax0 * x1 * x2 * x3);
            double d1 = +-(ax1 * x0 * x2 * x3);
            double d2 = +-(ax2 * x0 * x1 * x3);
            double d3 = +-(ax3 * x0 * x1 * x2);


            a = Math.Round(ax0 + ax1 + ax2 + ax3, 4);
            b = Math.Round(bx0 + bx1 + bx2 + bx3, 4);
            c = Math.Round(cx0 + cx1 + cx2 + cx3, 4);
            d = Math.Round(d0 + d1 + d2 + d3, 4);

            txtResultado.Text = $"{a}x^3 + {b}x^2 + {c}x + {d}";
            MessageBox.Show($"{a}x^3 + {b}x^2 + {c}x + {d}");
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            graficoPL.Series[0].Points.Clear();
            double x = -5;
            double y;
            double y1;
            double y2;
            for(int i = 0; i < 21; i++)
            {
                y1 = x * x * x * a;
                y2 = x * x * b;
                y = y1 + y2 + (c * x) + d;
                graficoPL.Series[0].Points.AddXY(x, y);
                x = x + .5;
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
