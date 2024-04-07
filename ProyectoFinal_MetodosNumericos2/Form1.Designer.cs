
namespace ProyectoFinal_MetodosNumericos2
{
    partial class frmNR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNR));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNR2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblNR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polinomiosDeLagrengeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosCuadradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuttaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.graficoNR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoNR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrafico
            // 
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.Location = new System.Drawing.Point(749, 478);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(112, 45);
            this.btnGrafico.TabIndex = 57;
            this.btnGrafico.Text = "Calcular Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(631, 478);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(112, 45);
            this.btnResultados.TabIndex = 56;
            this.btnResultados.Text = "Calcular g(Xi)";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(15, 242);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(321, 212);
            this.lstResultados.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Xi:";
            // 
            // txtXi
            // 
            this.txtXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXi.Location = new System.Drawing.Point(43, 189);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(57, 22);
            this.txtXi.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Introduce Xi";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(109, 113);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(39, 22);
            this.txtB.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "x +";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "x^2 +";
            // 
            // lblNR2
            // 
            this.lblNR2.AutoSize = true;
            this.lblNR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNR2.Location = new System.Drawing.Point(12, 65);
            this.lblNR2.Name = "lblNR2";
            this.lblNR2.Size = new System.Drawing.Size(849, 32);
            this.lblNR2.TabIndex = 50;
            this.lblNR2.Text = resources.GetString("lblNR2.Text");
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(15, 113);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(39, 22);
            this.txtA.TabIndex = 42;
            // 
            // lblNR
            // 
            this.lblNR.AutoSize = true;
            this.lblNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNR.Location = new System.Drawing.Point(12, 39);
            this.lblNR.Name = "lblNR";
            this.lblNR.Size = new System.Drawing.Size(182, 16);
            this.lblNR.TabIndex = 49;
            this.lblNR.Text = "Método Newton-Raphson";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "x^3 +";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 25);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bisecciónToolStripMenuItem,
            this.polinomiosDeLagrengeToolStripMenuItem,
            this.minimosCuadradosToolStripMenuItem,
            this.rungeKuttaToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // bisecciónToolStripMenuItem
            // 
            this.bisecciónToolStripMenuItem.Name = "bisecciónToolStripMenuItem";
            this.bisecciónToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.bisecciónToolStripMenuItem.Text = "Bisección";
            this.bisecciónToolStripMenuItem.Click += new System.EventHandler(this.bisecciónToolStripMenuItem_Click_1);
            // 
            // polinomiosDeLagrengeToolStripMenuItem
            // 
            this.polinomiosDeLagrengeToolStripMenuItem.Name = "polinomiosDeLagrengeToolStripMenuItem";
            this.polinomiosDeLagrengeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.polinomiosDeLagrengeToolStripMenuItem.Text = "Polinomios de Lagrenge";
            this.polinomiosDeLagrengeToolStripMenuItem.Click += new System.EventHandler(this.polinomiosDeLagrengeToolStripMenuItem_Click);
            // 
            // minimosCuadradosToolStripMenuItem
            // 
            this.minimosCuadradosToolStripMenuItem.Name = "minimosCuadradosToolStripMenuItem";
            this.minimosCuadradosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.minimosCuadradosToolStripMenuItem.Text = "Minimos Cuadrados";
            this.minimosCuadradosToolStripMenuItem.Click += new System.EventHandler(this.minimosCuadradosToolStripMenuItem_Click);
            // 
            // rungeKuttaToolStripMenuItem
            // 
            this.rungeKuttaToolStripMenuItem.Name = "rungeKuttaToolStripMenuItem";
            this.rungeKuttaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.rungeKuttaToolStripMenuItem.Text = "Runge-Kutta";
            this.rungeKuttaToolStripMenuItem.Click += new System.EventHandler(this.rungeKuttaToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(203, 113);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(39, 22);
            this.txtC.TabIndex = 44;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(281, 113);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(39, 22);
            this.txtD.TabIndex = 45;
            // 
            // graficoNR
            // 
            chartArea8.Name = "ChartArea1";
            this.graficoNR.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.graficoNR.Legends.Add(legend8);
            this.graficoNR.Location = new System.Drawing.Point(353, 242);
            this.graficoNR.Name = "graficoNR";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "g(Xi)";
            this.graficoNR.Series.Add(series8);
            this.graficoNR.Size = new System.Drawing.Size(508, 212);
            this.graficoNR.TabIndex = 58;
            this.graficoNR.Text = "chart1";
            // 
            // frmNR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 537);
            this.Controls.Add(this.graficoNR);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNR2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblNR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtD);
            this.Name = "frmNR";
            this.Text = "Newton-Raphson";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoNR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNR2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblNR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polinomiosDeLagrengeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosCuadradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoNR;
    }
}

