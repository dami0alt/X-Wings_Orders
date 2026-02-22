
namespace FormsEDI
{
    partial class Form1
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
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.btnOpenCristal = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(23, 12);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(259, 19);
            this.btnSelectPath.TabIndex = 0;
            this.btnSelectPath.Text = "Select Edi";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(295, 12);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(953, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(20, 20);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(10);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(640, 386);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.SelectedIndexChanged += new System.EventHandler(this.lbStatus_SelectedIndexChanged);
            // 
            // btnOpenCristal
            // 
            this.btnOpenCristal.Location = new System.Drawing.Point(23, 17);
            this.btnOpenCristal.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCristal.Name = "btnOpenCristal";
            this.btnOpenCristal.Size = new System.Drawing.Size(259, 19);
            this.btnOpenCristal.TabIndex = 3;
            this.btnOpenCristal.Text = "Open Cristal reports";
            this.btnOpenCristal.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(23, 36);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(259, 19);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process EDI";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btnSelectPath);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 65);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1380, 426);
            this.panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(684, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(676, 386);
            this.textBox1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(660, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 386);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOpenCristal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1380, 100);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1380, 426);
            this.panel4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 591);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Button btnOpenCristal;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

