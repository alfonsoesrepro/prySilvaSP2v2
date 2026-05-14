using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace prySilvaSP2v2
{
    internal class CCantante
    {
        // propiedades de la clase
        public DataTable dtCantantes; 
        private OleDbDataAdapter da; 
        private string ERROR = "";  
        
        // constructor de la clase
        public CCantante (OleDbConnection cnn, DataSet ds) 
        {     
            ERROR = "";     
            
            try     
            {   
                OleDbCommand cmd = new OleDbCommand(); // Objeto Command      
                cmd.Connection = cnn;         
                cmd.CommandType = CommandType.TableDirect;         
                cmd.CommandText = "Cantantes";         
                
                da = new OleDbDataAdapter(cmd); // DataAdapter
                da.Fill(ds, "Cantantes");       // Método Fill para llenar el DataSet  
                dtCantantes = ds.Tables["Cantantes"]; // Referencia a la tabla

                DataColumn[] dc = new DataColumn[1]; // Clave primaria        
                dc[0] = ds.Tables["Cantantes"].Columns["IdCantante"];         
                ds.Tables["Cantantes"].PrimaryKey = dc;         
                
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da); // Actualiza la BD    
            }     
            catch(Exception ex)     
            {         
                ERROR = ex.Message;
            } 
        }

        // método para agregar un nuevo registro a la tabla de Cantantes
        public bool NuevoCantante(long Id, string Nombre) 
        {     
            ERROR = "";     
            bool resultado = false;     
            
            try     
            {
                DataRow drNuevo = dtCantantes.NewRow(); // DataRow   
                drNuevo["IdCantante"] = Id;         
                drNuevo["Nombre"] = Nombre;
                
                dtCantantes.Rows.Add(drNuevo);
                da.Update(dtCantantes);
                
                resultado = true;     
            }     
            catch(Exception ex)     
            {         
                ERROR = ex.Message;     
            }     
            
            return resultado; 
        }

        // método para controlar si el Id de un cantante ya existe en la tabla
        public bool BuscarCantante(long Id) 
        {     
            ERROR = "";     
            bool resultado = false;     
            
            try     
            {         
                object[] valor = new object[1];         
                valor[0] = Id;         
                DataRow dr = dtCantantes.Rows.Find(valor);         
                
                if(!(dr is null))
                {             
                    resultado = true;
                }     
            }     
            catch(Exception ex)     
            {         
                ERROR = ex.Message;     
            }     
            
            return resultado; 

            // devuelve true si ese Id ya existe y false en caso contrario
        }

        public string ObtenerError() 
        { 
            return ERROR; 
        }
    }
}