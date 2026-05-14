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
    public partial class frmTema : Form
    {
        public frmTema()
        {
            InitializeComponent();
        }

        private CConexion conexion; 
        private CCantante cantante; 
        private CTema tema;

        private void frmTema_Load(object sender, EventArgs e)
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
                cantante = new CCantante(conexion.CNN, conexion.DS);

                //cargar el combo
                cmbCantantes.DisplayMember = "Nombre";         
                cmbCantantes.ValueMember = "IdCantante";         
                cmbCantantes.DataSource = cantante.dtCantantes;         
                
                tema = new CTema(conexion.CNN, conexion.DS);     
            } 
        }

        private bool ValidarDatos() 
        { 
            bool resultado = false; 
            long Id = 0; 
            
            if (txtID.Text != "" && txtNombre.Text != "" 
                && txtLink.Text != "" && cmbCantantes.SelectedIndex != -1) 
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            long IdTema = 0; 
            string Nombre = ""; 
            string Link = ""; 
            long IdCantante = 0; 
            
            if (ValidarDatos()) 
            {         
                long.TryParse(txtID.Text, out IdTema); 
                Nombre = txtNombre.Text;         
                long.TryParse ( cmbCantantes.SelectedValue.ToString(), out IdCantante);         
                Link = txtLink.Text;  
                
                // controlar que no se repita el valor del tema y cantante
                if (tema.BuscarTema(IdTema, IdCantante) == false)         
                {  
                    if (tema.NuevoTema(IdTema, IdCantante, Nombre, Link))             
                    {                 
                        txtID.Text = ""; 
                        txtNombre.Text = "";                 
                        txtLink.Text = "";             
                    }             
                    else             
                    {                 
                        MessageBox.Show("Error grabando el tema");             
                    }         
                }         
                else         
                {             
                    MessageBox.Show("El ID del tema y cantante ya existe");         
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