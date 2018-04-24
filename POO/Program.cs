using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionManager = new ConnectionManager();
            var conexion =connectionManager.GetConnection("SQL");
            conexion.Conectar();

            var conexionMySQL = (MySQLConnection)connectionManager.GetConnection("MYSQL");
            conexionMySQL.Conectar();
            conexionMySQL.CrearUsuario();
            conexionMySQL.Desconectar();
            //conexionMySQL.Actualizar(); //metodo definido como protected
            connectionManager.Autenticar(conexion);
            connectionManager.Autenticar(conexionMySQL);
            connectionManager.GetConnection(conexion);
            connectionManager.GetConnection(conexionMySQL);

            var personaSQL = conexion.CrearPersona(new Persona());
            var personaMYSql = conexionMySQL.CrearPersona("Omar", "El poeta");
            Console.WriteLine(personaSQL.NombreCompleto);
            Console.WriteLine(personaMYSql.NombreCompleto);

            Console.WriteLine(conexionMySQL.GetConnectionStr(3));
            Console.ReadKey();
        }
    }
}
