
namespace Formularios_prueba
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
            this.SuspendLayout();
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(44, 31);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(345, 23);
            this.btnSelectPath.TabIndex = 0;
            this.btnSelectPath.Text = "Select Edi";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(420, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(621, 22);
            this.txtPath.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 16;
            this.lbStatus.Location = new System.Drawing.Point(44, 103);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(997, 404);
            this.lbStatus.TabIndex = 2;
            // 
            // btnOpenCristal
            // 
            this.btnOpenCristal.Location = new System.Drawing.Point(44, 538);
            this.btnOpenCristal.Name = "btnOpenCristal";
            this.btnOpenCristal.Size = new System.Drawing.Size(345, 23);
            this.btnOpenCristal.TabIndex = 3;
            this.btnOpenCristal.Text = "Open Cristal reports";
            this.btnOpenCristal.UseVisualStyleBackColor = true;
            this.btnOpenCristal.Click += new System.EventHandler(this.btnOpenCristal_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(44, 60);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(345, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process EDI";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 630);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnOpenCristal);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSelectPath);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Button btnOpenCristal;
        private System.Windows.Forms.Button btnProcess;
    }
}

