using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace prySilvaSP2v2
{
    internal class CTema
    {
        // propiedades de la clase
        public DataTable dtTemas; 
        private OleDbDataAdapter da; 
        private string ERROR = "";  
        
        // constructor de la clase
        public CTema(OleDbConnection cnn, DataSet ds) 
        {     
            ERROR = "";     
            
            try     
            {  
                OleDbCommand cmd = new OleDbCommand();         
                cmd.Connection = cnn;         
                cmd.CommandType = CommandType.TableDirect;         
                cmd.CommandText = "Temas";       
              
                da = new OleDbDataAdapter(cmd);
                da.Fill(ds, "Temas");         
                dtTemas = ds.Tables["Temas"];         
                
                DataColumn[] dc = new DataColumn[2];         
                dc[0] = ds.Tables["Temas"].Columns["IdTema"];         
                dc[1] = ds.Tables["Temas"].Columns["IdCantante"];         
                ds.Tables["Temas"].PrimaryKey = dc;         
                
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);         
            }     
            catch (Exception ex)     
            {         
                ERROR = ex.Message;
            } 
        }

        // método para agregar un nuevo registro a la tabla de Temas
        public bool NuevoTema(long IdTema, long IdCantante, string Nombre, string Link) 
        {     
            ERROR = "";     
            bool resultado = false;     
            
            try     
            {    
                DataRow drNuevo = dtTemas.NewRow();         
                drNuevo["IdTema"] = IdTema;         
                drNuevo["IdCantante"] = IdCantante;         
                drNuevo["Nombre"] = Nombre;         
                drNuevo["Link"] = Link;

                dtTemas.Rows.Add(drNuevo);
                da.Update(dtTemas);         
                
                resultado = true;     
            }     
            catch (Exception ex)     
            {         
                ERROR = ex.Message;     
            }     
            
            return resultado; 
        }

        // método para controlar si el Id del tema y el Id de un cantante ya existen en la tabla
        public bool BuscarTema(long IdTema, long IdCantante) 
        {     
            ERROR = "";     
            bool resultado = false;     
            
            try     
            {         
                object[] valor = new object[2];         
                valor[0] = IdTema;         
                valor[1] = IdCantante;                            
                DataRow dr = dtTemas.Rows.Find(valor);         
                
                if (!(dr is null)) 
                {             
                    resultado = true;
                }     
            }     
            catch (Exception ex)     
            {         
                ERROR = ex.Message;     
            }     
            
            return resultado; 

            // devuelve true si esos Ids ya existen y false en caso contrario
        }

        // método para obtener un DataTable con los temas que pertenecen a un cantante
        public DataTable ObtenerTemasDeCantante(long IdCantante) 
        {     
            ERROR = "";     
            DataTable dtTemasCantante = null;     
            
            try     
            {         
                // se crea una tabla de Temas con la misma estructura que la original
                dtTemasCantante = dtTemas.Clone();         
                
                foreach (DataRow dr in dtTemas.Rows)         
                {  
                    if (IdCantante == long.Parse(dr["IdCantante"].ToString()))             
                    {                 
                        // agregar ese registro a la tabla clonada de Temas
                        dtTemasCantante.ImportRow(dr);     
                    }         
                }     
            }     
            catch (Exception ex)     
            {         
                ERROR = ex.Message;     
            }     
            
            return dtTemasCantante;  
        }

        public string ObtenerLinkTemaCantante(long IdTema, long IdCantante)
        {
            ERROR = ""; 
            string Link = ""; 
            
            try
            {
                object[] valor = new object[2]; 
                valor[0] = IdTema; 
                valor[1] = IdCantante; 
                DataRow dr = dtTemas.Rows.Find(valor); 
                
                if (!(dr is null)) 
                {             
                    Link = (string)dr["Link"];         
                }     
            }     
            catch (Exception ex)     
            {  
                ERROR = ex.Message;     
            }     
            
            return Link; 
        }

        public string ObtenerError() 
        { 
            return ERROR; 
        }
    }
}