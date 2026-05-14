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

        private void cmdVerVideo_Click(object sender, EventArgs e)
        {
            if (txtLink.Text != "")
            {    
                Xpcom.Initialize("Firefox"); // iniciar el componente de Firefox 
                
                geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill }; // crear el control webBrowser 
                grpBrowser.Controls.Add(geckoWebBrowser); // agregarlo al groupBox 
                geckoWebBrowser.Navigate(txtLink.Text); // navegar a la URL   
            } 
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Desconectar();     
            
            // controlar el estado del webBrowser
            if(!(geckoWebBrowser is null))     
            {   
                geckoWebBrowser.Stop(); 
                geckoWebBrowser.Dispose();     
            }     
            
            Close();
        }
    }
}