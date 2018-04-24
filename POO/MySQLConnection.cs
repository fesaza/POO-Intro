using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class MySQLConnection : Conexion
    {
        public override void Desconectar()
        {
            Console.WriteLine("Desconectando desde MySQL...");
            Console.WriteLine(Server);
            Console.WriteLine(BD);
        }

        public override bool Autenticar()
        {

            Console.WriteLine("Autenticando MySQL");
            return false;
        }

        public void CrearUsuario()
        {
            Actualizar();
            Console.WriteLine("Creando usuario..");
        }

        public override Persona CrearPersona(Persona persona)
        {
            persona.Nombre = "Jefferson";
            persona.Apellidos = "Farfan";
            return base.CrearPersona(persona);
        }

        public override Persona CrearPersona(string Nombre, string Apellidos)
        {
            return new Persona()
            {
                Id = 2,
                Nombre =Nombre,
                Apellidos =Apellidos
            };
        }
    }
}
