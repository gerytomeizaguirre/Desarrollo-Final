using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;


namespace administracion1
{
    
    public class conexion
    {
         
        SqlConnection conectar;
        SqlCommand comando;
        SqlDataReader dataleer;
        //---------------CONEXION A LA BASE DE DATOS---------------------------

        public static SqlConnection enlace()
        {
            SqlConnection conexiondata = new SqlConnection("Data Source=USER1-PC\\DAVID;Initial Catalog=Data_ZUMOT;Integrated Security=True");
            
                conexiondata.Open();
                return conexiondata;
            
     
        }

     
        
        //-------------------------SELECCION DE TIPO DE MATERIAL---------------------------
        public void SeleccionTipoMaterial(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("SELECT nombre_tipo_material FROM tipo_material"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }

            conectar.Close();
            t.Items.Insert(0, "SELECCIONE EL TIPO DE MATERIAL");
            t.SelectedIndex = 0;
            return;
        }



        //---------------------------SELECCION DE MATERIAL POR TIPO-------------------------

        public void SeleccionMaterial(ComboBox t, string m)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select a.nombre_material from material a inner join tipo_material b on a.id_tipomaterial = b.id_tipo_material where b.nombre_tipo_material = '" + m + "' order by a.nombre_material"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }

            conectar.Close();
            t.Items.Insert(0, "SELECCIONE MATERIAL");
            t.SelectedIndex = 0;
            return;
        }

     

        public int VerificarPreguntas(string pre, string user)
        {

            SqlCommand cmd;
            

            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from empleado_respuestas a inner join empleados b on a.id_empleado = b.id_empleado where b.usuario_empleado = @user and a.Respuesta_Pregunta1 = @pre", conectar);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("pre", pre);
                SqlDataAdapter dtadap = new SqlDataAdapter(cmd);
                DataTable datatabla = new DataTable();
                dtadap.Fill(datatabla);

                contador = datatabla.Rows.Count;
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien la pregunta: " + ex.ToString());
            }
            finally
            {
                conectar.Close();
            }
            return contador;

        }

        //-----------------------------Verificar Preguntas----------------------------------

        public int VerificarPreguntas2(string pre, string user)
        {

            SqlCommand cmd;
                       

            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select a.Respuesta_Pregunta2 from empleado_respuestas a inner join empleados b on a.id_empleado = b.id_empleado where b.usuario_empleado = @user and a.Respuesta_Pregunta2 = @pre", conectar);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("pre", pre);
                SqlDataAdapter dtadap = new SqlDataAdapter(cmd);
                DataTable datatabla = new DataTable();
                dtadap.Fill(datatabla);

                contador = datatabla.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien la pregunta: " + ex.ToString());
            }
            finally
            {
                conectar.Close();
            }
            return contador;
        }

        //----------------------------------------------------------CAMBIAR CONTRASEñA---------------------------------------------------------

        public int ActualizarContraseña(string Contraseña, string user)
        {
            int y = 0;
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            {
                cmd = new SqlCommand(string.Format("Update empleados set contraseña_empleado = '" + Contraseña + "' where usuario_empleado = " + user + "   ", Contraseña, user), cn);
                y = cmd.ExecuteNonQuery();
                cn.Close();

            }

            return y;

        }
        //----------------------------------------------------------SOLICITUD---------------------------------------------------------
        public string[] captar(string nombre)
        {
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();

            cmd = new SqlCommand("select nombre_cliente from proyecto where identidad_cliente='" + nombre + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                   

                };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }

        public string[] obte_tipo(string nombre)
        {
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();

            cmd = new SqlCommand("select id_tipo_material from tipo_material  where nombre_tipo_material='" + nombre + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),


                };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }
        public string[] obte_mate(string nombre)
        {
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();

            cmd = new SqlCommand("select id_material from material  where nombre_material='" + nombre + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),


                };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }
        public DataTable Mostrarinventario(string material)
        {

            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            SqlDataAdapter da;
            DataTable dt;
            da = new SqlDataAdapter("select id_material, nombre_material, cantidad_bodega from material where nombre_material ='" + material + "'", cn);
            dt = new DataTable("tabla");
            da.Fill(dt);

            cn.Close();
            return dt;
        }
        //-------------------------------------solicitudes pendientes-----------------------------------------------------------------------------------------
        public DataTable mostarsoli()
        {
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            SqlDataAdapter da;
            DataTable dt;
            da = new SqlDataAdapter("select * from solicitud ",cn);
            dt = new DataTable("tabla");
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public string[] cantidad(string material)
        {
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();

            cmd = new SqlCommand("select a.cantidad_bodega from material a where a.nombre_material ='" + material + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString()


                };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }
        /*-------------------------------------------Detalle------------------------------------------------------------------*/
        public string[] captar_detalle(string nombre)
        {
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();

            cmd = new SqlCommand("select c.nombre_cliente, a.fecha, b.descripcion_tipo_solicitud from solicitud a inner join tipo_solicitud b on a.id_tipo_solicitud = b.id_tipo_solicitud inner join proyecto c on a.identidad_cliente=c.identidad_cliente where a.identidad_cliente='" + nombre + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString()
                    

                };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }
        public DataTable Mostrar_detalle(string id)
        {
            
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            SqlDataAdapter da;
            DataTable dt;
            da = new SqlDataAdapter("select a.id_solicitud, b.nombre_material,c.nombre_tipo_material from solicitud a inner join material b on a.id_material= b.id_material inner join tipo_material c on a.id_tipo_material=c.id_tipo_material where a.identidad_cliente ='" + id + "'", cn);
            dt = new DataTable("tabla");
            da.Fill(dt);


            cn.Close();
            return dt;
        }
    }
}
