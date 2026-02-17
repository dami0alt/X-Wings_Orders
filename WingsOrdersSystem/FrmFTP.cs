using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WingsOrdersSystem
{



	public partial class FrmFTP : Form
	{

		public FrmFTP()
		{
			InitializeComponent();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
            try
            {
                var config = FtpConfigReader.Load("FTP_XML.xml");
                var ftpService = new FtpService(config);

                string[] remoteFiles = ftpService.ListFiles();

                foreach (var file in remoteFiles)
                {
                    // Solo procesamos EDI
                    if (!file.EndsWith(".edi", StringComparison.OrdinalIgnoreCase))
                        continue;

                    string localPath = Path.Combine(config.LocalFolder, file);

                    // Si no existe localmente → es nuevo
                    if (!File.Exists(localPath))
                    {
                        ftpService.DownloadFile(file);
                        ftpService.MoveToProcessed(file);

                        txtLog.AppendText($"Procesado: {file}\r\n");
                    }
                }

                txtLog.AppendText("Proceso finalizado.\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
	}
}
