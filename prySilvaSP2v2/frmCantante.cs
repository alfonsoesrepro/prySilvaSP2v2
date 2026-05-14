using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaSP2v2
{
    public partial class frmCantante : Form
    {
        public frmCantante()
        {
            InitializeComponent();
        }

        private CConexion conexion;
        private CCantante cantante;

        private void frmCantante_Load(object sender, EventArgs e)
        {
            conexion = new CConexion();    
            
            if(!conexion.Conectar("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" 
                + Application.StartupPath + "\\Academia.mdb"))     
            {         
                MessageBox.Show(conexion.ObtenerError());         
                Close(); // el formulario se cierra ya que no se podrá usar.
            }     
           
            cantante = new CCantante(conexion.CNN, conexion.DS);
        }

        private bool ValidarDatos()
        {
            bool resultado = false; 
            long Id = 0;     
            
            if (txtID.Text != "" && txtNombre.Text != "")     
            {         
                if (long.TryParse(txtID.Text, out Id))         
                {  
                    if (Id > 0)             
                    {                 
                        resultado = true;             
                    }         
                }     
            }     
            
            return resultado; 
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            long Id = 0; 
            string Nombre = ""; 
            
            if (ValidarDatos())
            {
                long.TryParse(txtID.Text, out Id); 
                Nombre = txtNombre.Text;          
                
                // verificar que no exista el mismo Id de cantante
                if (cantante.BuscarCantante(Id) == false)         
                {   
                    if(cantante.NuevoCantante(Id, Nombre))             
                    {                 
                        txtID.Text = ""; 
                        txtNombre.Text = "";             
                    }             
                    else             
                    {                 
                        MessageBox.Show("Error grabando el cantante");             
                    }         
                }         
                else         
                {             
                    MessageBox.Show("El ID del cantante ya existe");  
                }     
            }     
            else     
            {         
                MessageBox.Show("Complete los datos requeridos");     
            } 
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            conexion.Desconectar(); 
            Close();
        }
    }
}