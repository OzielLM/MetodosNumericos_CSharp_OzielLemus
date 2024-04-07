
namespace ProyectoFinal_MetodosNumericos2
{
    partial class frmRK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRK));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polinomiosDeLagrengeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosCuadradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMC2 = new System.Windows.Forms.Label();
            this.lblMC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtiX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtiY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAprox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.graficoRK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoRK)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 25);
            this.menuStrip1.TabIndex = 131;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonRaphsonToolStripMenuItem,
            this.bisecciónToolStripMenuItem,
            this.polinomiosDeLagrengeToolStripMenuItem,
            this.minimosCuadradosToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newtonRaphsonToolStripMenuItem
            // 
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton-Raphson";
            this.newtonRaphsonToolStripMenuItem.Click += new System.EventHandler(this.newtonRaphsonToolStripMenuItem_Click);
            // 
            // bisecciónToolStripMenuItem
            // 
            this.bisecciónToolStripMenuItem.Name = "bisecciónToolStripMenuItem";
            this.bisecciónToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.bisecciónToolStripMenuItem.Text = "Bisección";
            this.bisecciónToolStripMenuItem.Click += new System.EventHandler(this.bisecciónToolStripMenuItem_Click);
            // 
            // polinomiosDeLagrengeToolStripMenuItem
            // 
            this.polinomiosDeLagrengeToolStripMenuItem.Name = "polinomiosDeLagrengeToolStripMenuItem";
            this.polinomiosDeLagrengeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.polinomiosDeLagrengeToolStripMenuItem.Text = "Polinomios de Lagrange";
            this.polinomiosDeLagrengeToolStripMenuItem.Click += new System.EventHandler(this.polinomiosDeLagrengeToolStripMenuItem_Click);
            // 
            // minimosCuadradosToolStripMenuItem
            // 
            this.minimosCuadradosToolStripMenuItem.Name = "minimosCuadradosToolStripMenuItem";
            this.minimosCuadradosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.minimosCuadradosToolStripMenuItem.Text = "Minimos Cuadrados";
            this.minimosCuadradosToolStripMenuItem.Click += new System.EventHandler(this.minimosCuadradosToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // lblMC2
            // 
            this.lblMC2.AutoSize = true;
            this.lblMC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC2.Location = new System.Drawing.Point(12, 70);
            this.lblMC2.Name = "lblMC2";
            this.lblMC2.Size = new System.Drawing.Size(879, 32);
            this.lblMC2.TabIndex = 200;
            this.lblMC2.Text = resources.GetString("lblMC2.Text");
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC.Location = new System.Drawing.Point(12, 44);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(148, 16);
            this.lblMC.TabIndex = 199;
            this.lblMC.Text = "Método Runge-Kutta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 201;
            this.label1.Text = "y\'=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 205;
            this.label3.Text = "Inicial x:";
            // 
            // txtiX
            // 
            this.txtiX.Location = new System.Drawing.Point(82, 154);
            this.txtiX.Name = "txtiX";
            this.txtiX.Size = new System.Drawing.Size(100, 20);
            this.txtiX.TabIndex = 206;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 207;
            this.label4.Text = "Inicial y:";
            // 
            // txtiY
            // 
            this.txtiY.Location = new System.Drawing.Point(272, 154);
            this.txtiY.Name = "txtiY";
            this.txtiY.Size = new System.Drawing.Size(100, 20);
            this.txtiY.TabIndex = 208;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 209;
            this.label5.Text = "Aproximacion:";
            // 
            // txtAprox
            // 
            this.txtAprox.Location = new System.Drawing.Point(506, 154);
            this.txtAprox.Name = "txtAprox";
            this.txtAprox.Size = new System.Drawing.Size(100, 20);
            this.txtAprox.TabIndex = 210;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 211;
            this.label6.Text = "h:";
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(652, 154);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(100, 20);
            this.txth.TabIndex = 212;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(15, 217);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(449, 212);
            this.lstResultados.TabIndex = 213;
            // 
            // graficoRK
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoRK.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoRK.Legends.Add(legend2);
            this.graficoRK.Location = new System.Drawing.Point(482, 217);
            this.graficoRK.Name = "graficoRK";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            this.graficoRK.Series.Add(series2);
            this.graficoRK.Size = new System.Drawing.Size(393, 212);
            this.graficoRK.TabIndex = 214;
            this.graficoRK.Text = "chart1";
            // 
            // btnGrafico
            // 
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.Location = new System.Drawing.Point(763, 452);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(112, 45);
            this.btnGrafico.TabIndex = 216;
            this.btnGrafico.Text = "Calcular Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(645, 452);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(112, 45);
            this.btnResultados.TabIndex = 215;
            this.btnResultados.Text = "Calcular Y";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 218;
            this.label2.Text = "x -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 219;
            this.label7.Text = "y";
            // 
            // frmRK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 507);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.graficoRK);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAprox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtiY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtiX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMC2);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRK";
            this.Text = "Runge-Kutta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoRK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polinomiosDeLagrengeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosCuadradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label lblMC2;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtiX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtiY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAprox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoRK;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}