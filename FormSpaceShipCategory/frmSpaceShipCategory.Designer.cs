
namespace FormSpaceShipCategory
{
    partial class frmSpaceShipCategory
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
            this.components = new System.ComponentModel.Container();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.logsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(249, 211);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(400, 31);
            this.txtDesc.TabIndex = 14;
            this.txtDesc.Tag = "DescSpaceShipCategory";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(128, 217);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(113, 23);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "Description";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(249, 146);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(213, 31);
            this.txtCode.TabIndex = 12;
            this.txtCode.Tag = "CodeSpaceShipCategory";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(179, 152);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(62, 23);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "Code";
            // 
            // logsTimer
            // 
            this.logsTimer.Interval = 2000;
            this.logsTimer.Tick += new System.EventHandler(this.logsTimer_Tick);
            // 
            // frmSpaceShipCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.ClientSize = new System.Drawing.Size(1513, 968);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSpaceShipCategory";
            this.Load += new System.EventHandler(this.frmSpaceShipCategory_Load);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblLog, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Timer logsTimer;
    }
}
