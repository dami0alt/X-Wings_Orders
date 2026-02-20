using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EdiProcessor;


namespace Formularios_prueba
{
    public partial class Form1 : Form
    {
        EdiParser edi = new EdiParser();
        string path;

        public Form1()
        {
            InitializeComponent();
            btnOpenCristal.Enabled = false;

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos edi (*.edi)|*.edi|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                txtPath.Text = rutaArchivo;
                lbStatus.Items.Add($"Status: Path selected [{rutaArchivo}]");
                path = rutaArchivo;
                btnOpenCristal.Enabled = true;
            }
            else
            {
                lbStatus.Items.Add("Status: Error, de file is not selected");
                btnOpenCristal.Enabled = false;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                edi.ReadEDI(path);
                lbStatus.Items.Add("Status: File readed and database updated");
            }
            catch (Exception a)
            {
                lbStatus.Items.Add($"Error: {a}");
            }
        }

        private void btnOpenCristal_Click(object sender, EventArgs e)
        {

        }
    }
}
