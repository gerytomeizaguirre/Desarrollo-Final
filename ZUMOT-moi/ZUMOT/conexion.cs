using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ZUMOT.Properties;
using System.Configuration;


namespace administracion1
{

    public class conexion
    {

        SqlConnection conectar;
        SqlCommand comando;
        SqlDataReader dataleer;
        //---------------CONEXION A LA BASE DE DATOS---------------------------

        public static string ObtenerString()
        {
            return Settings.Default.Data_ZUMOTConnectionString;
        }
        public static SqlConnection enlace()
        {
            SqlConnection conexiondata = new SqlConnection("Data Source=LAPTOP-FJ5G6FGJ\\SQLEXPRESS;Initial Catalog=Data_ZUMOT;Integrated Security=True");

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

        //--------------------------FUNCION PARA COMPROBAR SI LAS PREGUNTAS SON CORRECTAS--------------------

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


        public string[] captar_info(string nombre)
        {
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();

            cmd = new SqlCommand("select a.nombre_cliente, a.apellido_cliente, a.celular, a.correo_electronico, a.nombre_trabajo, a.fecha_de_nacimiento, b.decripcion, c.decripcion_estatus, a.antiguedad_laboral, a.telefono_trabajo, a.direccion_trabajo,a.ingreso_extra, a.rtn from proyecto a inner join estado_civil b on a.id_estado_civil=b.id_estado_civil inner join estatus_laboral c on a.id_estatus=c.id_estatus where a.identidad_cliente='" + nombre + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString(),
                    dr[9].ToString(),
                    dr[10].ToString(),
                    dr[11].ToString(),
                    dr[12].ToString()

                };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }

        //-------------------------------MUESTRA LA CANTIDAD DE MATERIALES EN INVENTARIO (PANTALLA DE ADMINISTRACION)

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

        //------------------------------MUESTRA EL ESTADO CIVIL COMO COMBOBOX
        public void Seleccionestado(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select decripcion from estado_civil"), conectar);
            dataleer = comando.ExecuteReader();
            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "SELECCIONE ESTADO CIVIL");
            t.SelectedIndex = 0;
            return;
        }

        //------------------------SELECCIÓN DE GENERO--------------------------------------
        public void Selecciongenero(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select decripcion_genero from genero"), conectar);
            dataleer = comando.ExecuteReader();
            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "SELECCIONE GENERO");
            t.SelectedIndex = 0;
            return;
        }
        //------------------------SELECCIÓN DE ESTATUS LABORAL--------------------------------------
        public void Seleccionestatus(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select decripcion_estatus from estatus_laboral"), conectar);
            dataleer = comando.ExecuteReader();
            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "SELECCIONE ESTATUS LABORAL");
            t.SelectedIndex = 0;
            return;
        }
        //------------------------SELECCIÓN DE ID DE VENDEDOR --------------------------------------
        public void SeleccionVENDEDOR(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select nombre_vendedor from vendedores "), conectar);
            dataleer = comando.ExecuteReader();
            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "SELECCIONE VENDEDOR");
            t.SelectedIndex = 0;
            return;
        }
        //-------------------FACTURA ADMINISTRACION------------------+-------------------------
        public int EditarFact(int factura, double valor, string fecha, string casa, string detalle)
        {
            SqlCommand cmd;
            int y = 0;
            conectar = enlace();
            {
                cmd = new SqlCommand("update gastos_administrativos  set Fecha ='" + fecha + "', Casa_comercial ='" + casa + "', Descripcion_gasto ='" + detalle + "', Valor_gasto ='" + valor + "'where Id_Factura_administrativa = '" + factura + "'", conectar);
                y = cmd.ExecuteNonQuery();
                conectar.Close();
            }
            return y;

        }
        //---------------------------------SELECCION DE PUESTO-------------------------------
        public void SeleccionPuesto(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select descripcion_puesto from puesto_empleado"), conectar);
            dataleer = comando.ExecuteReader();
            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "SELECCIONE PUESTO");
            t.SelectedIndex = 0;
            return;
        }

        /**************************************MODIFICAR ROL**********************************************************************************/
        public int Actualizarrol(string nombrerol, int id_rol)
        {
            int y = 0;
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            {
                cmd = new SqlCommand(string.Format("Update rol set descripcion_puesto = '" + nombrerol + "' where id_rol = " + id_rol + "   ", nombrerol, id_rol), cn);
                y = cmd.ExecuteNonQuery();
                cn.Close();

            }

            return y;

        }
        /*INGRESAR ROL EN LA BASE DE DATOS*/
        public void guardarrol(String nombre)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("Insert into rol (descripcion_puesto) values ('" + nombre + "')", nombre), conectar);
            if (comando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Se Guardó el rol correctamente");

            }
            conectar.Close();

            return;
        }
        //---------------------------OBTENER SOLAMENTE NUMEROS POR MEDIO DE KEYPRESS----------------------

        public static void ValidarNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        //-------------------------VALIDACION DEL CONTENIDO PARA NOMBRE DE USUARIO, SOLO ACEPTA  MINUSCULA Y NUMEROS Y MAYOR DE 5 CARACTER
        //----------------------VALIDACION POR MEDIO DE EXPRESION REGULAR....
        public static bool verificaruser(string user)
        {
            string expresion = "^(?=.*[a-z])(?=.*[0-9]).{5,15}$";
            if (Regex.IsMatch(user, expresion))
            {
                if (Regex.Replace(user, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //------------------------VERIFICAR LOS AÑOS LABORALES---------
        public static bool verificaryears(string dato)
        {

            if (Convert.ToInt32(dato) < 40 && Convert.ToInt32(dato) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //-----------------VERIFICACION DE CONTRA CON METODO DE EXPRECION REGULAR
        //-----------------SOLO NUMEROS, MAYUSCULA Y NUMEROS, Y MAYOR DE 8 CARACTER

        public static bool verificarcontra(string pass)
        {
            string expresion = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$";
            if(Regex.IsMatch(pass, expresion))
            {
                if(Regex.Replace(pass, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //-------------------VERIFICACION DEL CORREO CON METODO DE EXPRECION REGULAR
        //--------------------PARA ACEPTAR EL FORMATO DE CORREO @DOMINIO.COM
        public static bool validaremail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //-----------------VERIFICACION DE NUMERO REAL
        //-----------------SOLO ACEPTA NUMEROS REALES CON DOBLE DECIMAL
        public static bool validarPuntoReal(string real)
        {
            string expresion = @"\b\d+\.\d{2}\b";
            if(Regex.IsMatch(real, expresion))
            {
                if(Regex.Replace(real, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //-------------------VALIDACION DEL TELEFONO CON METODO EXPRECION REGULAR
        //-------------------SOLO ACEPTA NUMEROS DE HONDURAS CON UNA CANTIDAD DE 8 NUMEROS
        public static bool validarTelefono(string tel)
        {
            string expresion = "^[2389]{1}[0-9]{7}$";
            if(Regex.IsMatch(tel, expresion))
            {
                if(Regex.Replace(tel, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        

        //---------------VALIDACION DE IDENTIDAD CON EXPRECION REGULAR
        //---------------SOLO ACEPTA NUMEROS DE LOS DEPARTAMENTOS Y MUNICIPIOS DE HONDURAS Y UNA CANTIDAD DE 13 NUMEROS 
        public static bool validarIdentidad(string id)
        {
            string expresion = "^[0-1]{1}[0-9]{1}[0-2]{1}[0-9]{1}[0-9]{9}$";
            if(Regex.IsMatch(id, expresion))
            {
                if (Regex.Replace(id, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
           

        }

        public static bool validarNombre(string nombre)
        {
            string expresion = "^(?=.*[a-z])(?=.*[A-Z])$";
            if(Regex.IsMatch(nombre, expresion))
            {
                if(Regex.Replace(nombre, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //----------------VALIDAR POR MEDIO DE KEYPRESS SOLO LETRAS

            public static void validarLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        //-----------VALIDAR POR MEDIO DE KEY PRESS SOLO NUMEROS Y PUNTO
        public static void ValidarReal(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        //--------------VALIDAR POR MEDIO DE KEY PRESS LA FECHA
        public static void Validarfecha(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 46) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }


        //--------------VALIDAR POR MEDIO DE KEY PRESS SOLO LETRAS Y NUMEROS
        public static void validarLetrasynumero(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
