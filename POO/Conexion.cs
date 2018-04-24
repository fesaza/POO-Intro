using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Conexion: ISecurity
    {
        public string BD { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }

        public Conexion()
        {
            BD = "basededatos";
            User = "Usuario";
            Password = "qwer";
            Server = "server";
        }

        public Conexion(string db, string User, string password, string server)
        {
            BD = db;
            this.User = User;
            Password = password;
            Server = server;
        }

        public virtual void Conectar()
        {
            Console.WriteLine("Conectando desde la clase conexion...");
        }

        public abstract void Desconectar();

        public override string ToString()
        {
            return Server + " " + User + " " + Password + " " + BD;
        }

        protected void Actualizar()
        {
            Console.WriteLine("Actualizando...");
        }

        public virtual bool Autenticar()
        {
            throw new NotImplementedException();
        }

        public virtual Persona CrearPersona(Persona persona)
        {
            persona.Id = 1;
            
            return persona;
        }

        public virtual Persona CrearPersona(string Nombre, string Apellidos)
        {
            var persona = new Persona()
            {
                Nombre = Nombre,
                Apellidos = Apellidos
            };
            return persona;
        }

        public static void Algo()
        {
            var MySqlConn = new MySQLConnection();
            MySqlConn.CrearPersona("", "");
        }
    }

    public static class ExtensionMethod
    {
        public static string GetConnectionStr(this Conexion conextion, int index, params string[] algo)
        {
            return (conextion.User + conextion.Server).Substring(index);
        }
    }
}
