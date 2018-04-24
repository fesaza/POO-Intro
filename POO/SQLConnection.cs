using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class SQLConnection : Conexion
    {
        public SQLConnection(): base("lappiz","lappuzuser","lappizpass","paris")
        {

        }

        public override void Conectar()
        {
            base.Conectar();
            Console.WriteLine("Conectando desde MSSQL...");
            Console.WriteLine(Server);
            Console.WriteLine(BD);
        }

        public override void Desconectar()
        {
            throw new NotImplementedException();
        }

        public override bool Autenticar()
        {
            Console.WriteLine("Autenticando MSSQL");
            return true;
        }
    }
}
