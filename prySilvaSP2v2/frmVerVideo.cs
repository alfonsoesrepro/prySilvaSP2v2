using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using Microsoft.Web.WebView2.WinForms;

namespace prySilvaSP2v2
{
    public partial class frmVerVideo : Form
    {
        public frmVerVideo()
        {
            InitializeComponent();
        }

        private CConexion conexion; 
        private CCantante cantante; 
        private CTema tema;
        private GeckoWebBrowser geckoWebBrowser;
        private WebView2 webView;

        private void frmVerVideo_Load(object sender, EventArgs e)
        {
            conexion = new CConexion();

            if (!conexion.Conectar("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" 
                + Application.StartupPath + "\\Academia.mdb")) 
            { 
                MessageBox.Show(conexion.ObtenerError()); 
                Close(); 
            }
            else
            {       
                tema = new CTema(conexion.CNN, conexion.DS);
                cantante = new CCantante(conexion.CNN, conexion.DS);         
                
                cmbCantantes.DisplayMember = "Nombre";         
                cmbCantantes.ValueMember = "IdCantante";         
                cmbCantantes.DataSource = cantante.dtCantantes;         
            } 
        }

        private void cmbCantantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            long IdCantante = long.Parse(cmbCantantes.SelectedValue.ToString());     
            
            cmbTemas.DisplayMember = "Nombre";     
            cmbTemas.ValueMember = "IdTema";     
            cmbTemas.DataSource = tema.ObtenerTemasDeCantante(IdCantante);
        }

        private void cmbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            long IdCantante = long.Parse(cmbCantantes.SelectedValue.ToString());     
            long IdTema = long.Parse(cmbTemas.SelectedValue.ToString());     
            
            txtLink.Text = tema.ObtenerLinkTemaCantante(IdTema, IdCantante); 
        }

        // Cambiado a async para usar await correctamente
        private async void cmdVerVideo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLink.Text))
            {
                // Si quieres usar Gecko, el código anterior era válido, pero aquí usamos WebView2
                if (webView == null)
                {
                    webView = new WebView2
                    {
                        Dock = DockStyle.Fill
                    };

                    grpBrowser.Controls.Add(webView);

                    // Inicializar el CoreWebView2 (necesita runtime)
                    await webView.EnsureCoreWebView2Async(null);
                }

                try
                {
                    webView.Source = new Uri(txtLink.Text);
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("El enlace no es una URL válida.", "URL inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Desconectar();     

            // Liberar WebView2 si existe
            if (webView != null)
            {
                webView.Dispose();
                webView = null;
            }     
            
            Close();
        }
    }
}