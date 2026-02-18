using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factories
{
    public partial class frmFactories : FormsDesigner.frmBase
    {
        FactoriesEntity ctx;
        BindingSource bsFactories;
        public frmFactories()
        {
            InitializeComponent();
            ctx = new FactoriesEntity();
            bsFactories = new BindingSource();
        }


        bool isNew;
        Color originalForeColor;

        #region Methods
        private void loadData()
        {
            bsFactories.DataSource = ctx.Factories.ToList();
            dgvBase.DataSource = bsFactories;
        }
        private void bindControls()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", bsFactories, txt.Tag.ToString(), false, DataSourceUpdateMode.OnValidation);
                }
            }
        }
        private void unbindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();
                    txt.Text = "";
                }
            }
        }
        private void configurateDataGridView()
        {
            dgvBase.Columns["idFactory"].Visible = false;
        }
        private void setNormalMode()
        {
            btnCreate.Text = "Create";
            btnCreate.ForeColor = originalForeColor;

            bindControls();
            isNew = false;
        }
        private void createRegister()
        {
            string code = txtCode.Text;
            string desc = txtDesc.Text;
            Factory f = new Factory
            {
                codeFactory = code,
                DescFactory = desc
            };
            ctx.Factories.Add(f);
        }
        private void updateData()
        {
            if (isNew)
            {
                createRegister();
                setNormalMode();
            }
            bsFactories.EndEdit();
            ctx.SaveChanges();
            loadData();
        }
        #endregion
        #region Events
        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var ent = e.Row.DataBoundItem as Factory;

            if (ent == null)
                return;

            if (ctx.Entry(ent).State != EntityState.Added)
            {
                ctx.Entry(ent).State = EntityState.Deleted;
            }
        }
        private void frmFactories_Load(object sender, EventArgs e)
        {
            isNew = false;
            loadData();
            bindControls();
            configurateDataGridView();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                originalForeColor = btnCreate.ForeColor;
                btnCreate.Text = "Cancel";
                btnCreate.ForeColor = Color.Red;

                unbindControls();
                isNew = true;
            }
            else
            {
                setNormalMode();
            }

        }
        #endregion
    }
}
