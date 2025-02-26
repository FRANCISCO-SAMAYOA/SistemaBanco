using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Clientes
    {
    
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarClientes()
        {
            string QryMostrarClientes = "usp_clientes_mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarClientes,db_conexion.MtdAbrirConexion());
            DataTable dtMostrarClientes = new DataTable();
            adapter.Fill(dtMostrarClientes);
            db_conexion.MtdCerrarConexion();
            return dtMostrarClientes;
        }

        public void CD_MtdAgregarClientes(string Nombre, string Direccion, string Departamento, string Pais, string Categoria, String Estado)
        {
            String Usp_crear = "usp_clientes_crear";
            SqlCommand cmd_InsertarClientes = new SqlCommand(Usp_crear, db_conexion.MtdAbrirConexion());
            cmd_InsertarClientes.CommandType = CommandType.StoredProcedure;
            cmd_InsertarClientes.Parameters.AddWithValue("@Nombre", Nombre);
            cmd_InsertarClientes.Parameters.AddWithValue("@Direccion", Direccion);
            cmd_InsertarClientes.Parameters.AddWithValue("@Departamento", Departamento);
            cmd_InsertarClientes.Parameters.AddWithValue("@Pais", Pais);
            cmd_InsertarClientes.Parameters.AddWithValue("@Categoria", Categoria);
            cmd_InsertarClientes.Parameters.AddWithValue("@Estado", Estado);
            cmd_InsertarClientes.ExecuteNonQuery();
        }

        public void CD_MtdAcutlizarClientes(int Codigo, string Nombre, string Direccion, string Departamento, string Pais, string Categoria, String Estado)
        {
            String Usp_actualizar = "usp_clientes_actualizar";
            SqlCommand cmd_ActualizarClientes = new SqlCommand(Usp_actualizar, db_conexion.MtdAbrirConexion());
            cmd_ActualizarClientes.CommandType = CommandType.StoredProcedure;
            cmd_ActualizarClientes.Parameters.AddWithValue("@Codigo", Codigo);
            cmd_ActualizarClientes.Parameters.AddWithValue("@Nombre", Nombre);
            cmd_ActualizarClientes.Parameters.AddWithValue("@Direccion", Direccion);
            cmd_ActualizarClientes.Parameters.AddWithValue("@Departamento", Departamento);
            cmd_ActualizarClientes.Parameters.AddWithValue("@Pais", Pais);
            cmd_ActualizarClientes.Parameters.AddWithValue("@Categoria", Categoria);
            cmd_ActualizarClientes.Parameters.AddWithValue("@Estado", Estado);
            cmd_ActualizarClientes.ExecuteNonQuery();
        }

        public void CD_MtdEliminarClientes(int Codigo, string Nombre, string Direccion, string Departamento, string Pais, string Categoria, String Estado)
        {
            String Usp_eliminar = "usp_clientes_eliminar";
            SqlCommand cmd_EliminarClientes = new SqlCommand(Usp_eliminar, db_conexion.MtdAbrirConexion());
            cmd_EliminarClientes.CommandType = CommandType.StoredProcedure;
            cmd_EliminarClientes.Parameters.AddWithValue("@Codigo", Codigo);
            cmd_EliminarClientes.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();
        }

    }
}
