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
    public partial class frmMC : Form
    {
        public frmMC()
        {
            InitializeComponent();
        }

        double[,] mR;
        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            #region Entradas
            double I1;
            double I2;
            double I3;
            double I4;
            double I5;

            double Xi1;
            double Xi2;
            double Xi3;
            double Xi4;
            double Xi5;

            double Yi1;
            double Yi2;
            double Yi3;
            double Yi4;
            double Yi5;

            double Xi2_1;
            double Xi2_2;
            double Xi2_3;
            double Xi2_4;
            double Xi2_5;

            double YiXi1;
            double YiXi2;
            double YiXi3;
            double YiXi4;
            double YiXi5;

            double Xi3_1;
            double Xi3_2;
            double Xi3_3;
            double Xi3_4;
            double Xi3_5;

            double YiXi2_1;
            double YiXi2_2;
            double YiXi2_3;
            double YiXi2_4;
            double YiXi2_5;

            double Xi4_1;
            double Xi4_2;
            double Xi4_3;
            double Xi4_4;
            double Xi4_5;

            double YiXi3_1;
            double YiXi3_2;
            double YiXi3_3;
            double YiXi3_4;
            double YiXi3_5;

            double Xi5_1;
            double Xi5_2;
            double Xi5_3;
            double Xi5_4;
            double Xi5_5;

            double Xi6_1;
            double Xi6_2;
            double Xi6_3;
            double Xi6_4;
            double Xi6_5;

            double m = 0;
            double SXi = 0;
            double SYi = 0;
            double SXi2 = 0;
            double SYiXi = 0;
            double SXi3 = 0;
            double SYiXi2 = 0;
            double SXi4 = 0;
            double SYiXi3 = 0;
            double SXi5 = 0;
            double SXi6 = 0;

            if (txtI1.Text == "" || txtI2.Text == "" || txtI3.Text == "" || txtI4.Text == "" || txtI5.Text == "")
            {
                I1 = 1;
                I2 = 2;
                I3 = 3;
                I4 = 4;
                I5 = 5;
            }
            else
            {
                I1 = double.Parse(txtI1.Text);
                I2 = double.Parse(txtI2.Text);
                I3 = double.Parse(txtI3.Text);
                I4 = double.Parse(txtI4.Text);
                I5 = double.Parse(txtI5.Text);
            }

            if (txtXi1.Text == "")
            {
                Xi1 = 0;
            }
            else
            {
                Xi1 = double.Parse(txtXi1.Text);
            }

            if (txtXi2.Text == "")
            {
                Xi2 = 0;
            }
            else
            {
                Xi2 = double.Parse(txtXi2.Text);
            }

            if (txtXi3.Text == "")
            {
                Xi3 = 0;
            }
            else
            {
                Xi3 = double.Parse(txtXi3.Text);
            }

            if (txtXi4.Text == "")
            {
                Xi4 = 0;
            }
            else
            {
                Xi4 = double.Parse(txtXi4.Text);
            }

            if (txtXi5.Text == "")
            {
                Xi5 = 0;
            }
            else
            {
                Xi5 = double.Parse(txtXi5.Text);
            }

            if (txtYi1.Text == "")
            {
                Yi1 = 0;
            }
            else
            {
                Yi1 = double.Parse(txtYi1.Text);
            }

            if (txtYi2.Text == "")
            {
                Yi2 = 0;
            }
            else
            {
                Yi2 = double.Parse(txtYi2.Text);
            }

            if (txtYi3.Text == "")
            {
                Yi3 = 0;
            }
            else
            {
                Yi3 = double.Parse(txtYi3.Text);
            }

            if (txtYi4.Text == "")
            {
                Yi4 = 0;
            }
            else
            {
                Yi4 = double.Parse(txtYi4.Text);
            }

            if (txtYi5.Text == "")
            {
                Yi5 = 0;
            }
            else
            {
                Yi5 = double.Parse(txtYi5.Text);
            }
#endregion

            Xi2_1 = Math.Pow(Xi1, 2);
            txtXi2_1.Text = Xi2_1.ToString();

            Xi2_2 = Math.Pow(Xi2, 2);
            txtXi2_2.Text = Xi2_2.ToString();

            Xi2_3 = Math.Pow(Xi3, 2);
            txtXi2_3.Text = Xi2_3.ToString();

            Xi2_4 = Math.Pow(Xi4, 2);
            txtXi2_4.Text = Xi2_4.ToString();

            Xi2_5 = Math.Pow(Xi5, 2);
            txtXi2_5.Text = Xi2_5.ToString();


            YiXi1 = Yi1 * Xi1;
            txtYIXi1.Text = YiXi1.ToString();

            YiXi2 = Yi2 * Xi2;
            txtYIXi2.Text = YiXi2.ToString();

            YiXi3 = Yi3 * Xi3;
            txtYIXi3.Text = YiXi3.ToString();

            YiXi4 = Yi4 * Xi4;
            txtYIXi4.Text = YiXi4.ToString();

            YiXi5 = Yi5 * Xi5;
            txtYIXi5.Text = YiXi5.ToString();


            Xi3_1 = Math.Pow(Xi1, 3);
            txtXi3_1.Text = Xi3_1.ToString();

            Xi3_2 = Math.Pow(Xi2, 3);
            txtXi3_2.Text = Xi3_2.ToString();

            Xi3_3 = Math.Pow(Xi3, 3);
            txtXi3_3.Text = Xi3_3.ToString();

            Xi3_4 = Math.Pow(Xi4, 3);
            txtXi3_4.Text = Xi3_4.ToString();

            Xi3_5 = Math.Pow(Xi5, 3);
            txtXi3_5.Text = Xi3_5.ToString();


            YiXi2_1 = Yi1 * Xi2_1;
            txtYIXi2_1.Text = YiXi2_1.ToString();

            YiXi2_2 = Yi2 * Xi2_2;
            txtYIXi2_2.Text = YiXi2_2.ToString();

            YiXi2_3 = Yi3 * Xi2_3;
            txtYIXi2_3.Text = YiXi2_3.ToString();

            YiXi2_4 = Yi4 * Xi2_4;
            txtYIXi2_4.Text = YiXi2_4.ToString();

            YiXi2_5 = Yi5 * Xi2_5;
            txtYIXi2_5.Text = YiXi2_5.ToString();


            Xi4_1 = Math.Pow(Xi1, 4);
            txtXi4_1.Text = Xi4_1.ToString();

            Xi4_2 = Math.Pow(Xi2, 4);
            txtXi4_2.Text = Xi4_2.ToString();

            Xi4_3 = Math.Pow(Xi3, 4);
            txtXi4_3.Text = Xi4_3.ToString();

            Xi4_4 = Math.Pow(Xi4, 4);
            txtXi4_4.Text = Xi4_4.ToString();

            Xi4_5 = Math.Pow(Xi5, 4);
            txtXi4_5.Text = Xi4_5.ToString();


            YiXi3_1 = Yi1 * Xi3_1;
            txtYIXi3_1.Text = YiXi3_1.ToString();

            YiXi3_2 = Yi2 * Xi3_2;
            txtYIXi3_2.Text = YiXi3_2.ToString();

            YiXi3_3 = Yi3 * Xi3_3;
            txtYIXi3_3.Text = YiXi3_3.ToString();

            YiXi3_4 = Yi4 * Xi3_4;
            txtYIXi3_4.Text = YiXi3_4.ToString();

            YiXi3_5 = Yi5 * Xi3_5;
            txtYIXi3_5.Text = YiXi3_5.ToString();


            Xi5_1 = Math.Pow(Xi1, 5);
            txtXi5_1.Text = Xi5_1.ToString();

            Xi5_2 = Math.Pow(Xi2, 5);
            txtXi5_2.Text = Xi5_2.ToString();

            Xi5_3 = Math.Pow(Xi3, 5);
            txtXi5_3.Text = Xi5_3.ToString();

            Xi5_4 = Math.Pow(Xi4, 5);
            txtXi5_4.Text = Xi5_4.ToString();

            Xi5_5 = Math.Pow(Xi5, 5);
            txtXi5_5.Text = Xi5_5.ToString();


            Xi6_1 = Math.Pow(Xi1, 6);
            txtXi6_1.Text = Xi6_1.ToString();

            Xi6_2 = Math.Pow(Xi2, 6);
            txtXi6_2.Text = Xi6_2.ToString();

            Xi6_3 = Math.Pow(Xi3, 6);
            txtXi6_3.Text = Xi6_3.ToString();

            Xi6_4 = Math.Pow(Xi4, 6);
            txtXi6_4.Text = Xi6_4.ToString();

            Xi6_5 = Math.Pow(Xi5, 6);
            txtXi6_5.Text = Xi6_5.ToString();


            m = I5;
            txtM.Text = m.ToString();

            SXi = Xi1 + Xi2 + Xi3 + Xi4 + Xi5;
            txtSXi.Text = SXi.ToString();

            SYi = Yi1 + Yi2 + Yi3 + Yi4 + Yi5;
            txtSYi.Text = SYi.ToString();

            SXi2 = Xi2_1 + Xi2_2 + Xi2_3 + Xi2_4 + Xi2_5;
            txtSXi2.Text = SXi2.ToString();

            SYiXi = YiXi1 + YiXi2 + YiXi3 + YiXi4 + YiXi5;
            txtSYiXi.Text = SYiXi.ToString();

            SXi3 = Xi3_1 + Xi3_2 + Xi3_3 + Xi3_4 + Xi3_5;
            txtSXi3.Text = SXi3.ToString();

            SYiXi2 = YiXi2_1 + YiXi2_2 + YiXi2_3 + YiXi2_4 + YiXi2_5;
            txtSYiXi2.Text = SYiXi2.ToString();

            SXi4 = Xi4_1 + Xi4_2 + Xi4_3 + Xi4_4 + Xi4_5;
            txtSXi4.Text = SXi4.ToString();

            SYiXi3 = YiXi3_1 + YiXi3_2 + YiXi3_3 + YiXi3_4 + YiXi3_5;
            txtSYiXi3.Text = SYiXi3.ToString();

            SXi5 = Xi5_1 + Xi5_2 + Xi5_3 + Xi5_4 + Xi5_5;
            txtSXi5.Text = SXi5.ToString();

            SXi6 = Xi6_1 + Xi6_2 + Xi6_3 + Xi6_4 + Xi6_5;
            txtSXi6.Text = SXi6.ToString();


            lstResultados.Items.Add($"{m}A0 + {SXi}A1 + {SXi2}A2 + {SXi3}A3 = {SYi}");
            lstResultados.Items.Add($"{SXi}A0 + {SXi2}A1 + {SXi3}A2 + {SXi4}A3 = {SYiXi}");
            lstResultados.Items.Add($"{SXi2}A0 + {SXi3}A1 + {SXi4}A2 + {SXi5}A3 = {SYiXi2}");
            lstResultados.Items.Add($"{SXi3}A0 + {SXi4}A1 + {SXi5}A2 + {SXi6}A3 = {SYiXi3}");

            double[][] se4x4 = MatrixCreate(4,4);
            se4x4[0][0] = m; se4x4[0][1] = SXi; se4x4[0][2] = SXi2; se4x4[0][3] = SXi3;
            se4x4[1][0] = SXi; se4x4[1][1] = SXi2; se4x4[1][2] = SXi3; se4x4[1][3] = SXi4;
            se4x4[2][0] = SXi2; se4x4[2][1] = SXi3; se4x4[2][2] = SXi4; se4x4[2][3] = SXi5;
            se4x4[3][0] = SXi3; se4x4[3][1] = SXi4; se4x4[3][2] = SXi5; se4x4[3][3] = SXi6;

            double[,] fres = new double[4, 1];
            fres[0, 0] = SYi;
            fres[1, 0] = SYiXi;
            fres[2, 0] = SYiXi2;
            fres[3, 0] = SYiXi3;


            double[][] invers = MatrixCreate(4,4);
            invers = MatrixInverse(se4x4);

            mR = new double[4, 1];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        mR[i, j] += invers[i][k] * fres[k, j];
                    }
                }
            }

            lstResultados.Items.Add("");
            lstResultados.Items.Add($"A0= {Math.Round(mR[0, 0], 4)}  A1= {Math.Round(mR[1, 0], 4)}  A2= {Math.Round(mR[2, 0], 4)}  A3= {Math.Round(mR[3, 0], 4)}");
            lstResultados.Items.Add("");
            lstResultados.Items.Add($"P3(x)= {Math.Round(mR[0, 0], 4)} + {Math.Round(mR[1, 0], 4)}x + {Math.Round(mR[2, 0], 4)}x^2 + {Math.Round(mR[3, 0], 4)}x^3");
            MessageBox.Show($"P3(x)= {Math.Round(mR[0, 0], 4)} + {Math.Round(mR[1, 0], 4)}x + {Math.Round(mR[2, 0], 4)}x^2 + {Math.Round(mR[3, 0], 4)}x^3");
        }

        #region Metodos de Matrices
        public static double[][] MatrixDecompose(double[][] matrix, out int[] perm, out int toggle)
        {
            int n = matrix.Length;
            double[][] result = MatrixDuplicate(matrix);
            perm = new int[n];
            for (int i = 0; i<n; ++i) 
            { 
                perm[i] = i; 
            }
            toggle = 1;
            for (int j = 0; j<n - 1; ++j)
            {
                double colMax = Math.Abs(result[j][j]);
                int pRow = j;
                for (int i = j + 1; i<n; ++i)
                {
                    if (result[i][j] > colMax)
                    {
                        colMax = result[i][j];
                        pRow = i;
                    }
                }
                if (pRow != j)
                {
                    double[] rowPtr = result[pRow];
                    result[pRow] = result[j];
                    result[j] = rowPtr;
                    int tmp = perm[pRow];
                    perm[pRow] = perm[j];
                    perm[j] = tmp;
                    toggle = -toggle;
                }
                if (Math.Abs(result[j][j]) < 1.0E-20)
                    return null;
                for (int i = j + 1; i < n; ++i)
                {
                    result[i][j] /= result[j][j];
                    for (int k = j + 1; k < n; ++k)
                        result[i][k] -= result[i][j] * result[j][k];
                }
            }
            return result;
        }

        static double[][] MatrixDuplicate(double[][] matrix)
        {
            double[][] result = MatrixCreate(matrix.Length, matrix[0].Length);
            for (int i = 0; i<matrix.Length; ++i)
                for (int j = 0; j<matrix[i].Length; ++j)
                    result[i][j] = matrix[i][j];
            return result;
        }

        static double[][] MatrixCreate(int rows, int cols)
        {
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols];
            return result;
        }

        static double[] HelperSolve(double[][] luMatrix,double[] b)
        {
            int n = luMatrix.Length;
            double[] x = new double[n];
            b.CopyTo(x, 0);
            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum;
            }
            x[n - 1] /= luMatrix[n - 1][n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum / luMatrix[i][i];
            }
            return x;
        }

        static double[][] MatrixInverse(double[][] matrix)
        {
            int n = matrix.Length;
            double[][] result = MatrixDuplicate(matrix);
            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm, out toggle);
            if (lum == null)
                throw new Exception("Unable to compute inverse");
            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }
                double[] x = HelperSolve(lum, b);
                for (int j = 0; j < n; ++j)
                    result[j][i] = x[j];
            }
            return result;
        }

        #endregion

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

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            graficoMC.Series[0].Points.Clear();
            double x = -5;
            double y;
            double y1;
            double y2;
            for (int i = 0; i < 21; i++)
            {
                y1 = x * x * x * mR[3,0];
                y2 = x * x * mR[2,0];
                y = y1 + y2 + (mR[1,0] * x) + mR[0,0];
                graficoMC.Series[0].Points.AddXY(x, y);
                x = x + .5;
            }
        }
    }
}
