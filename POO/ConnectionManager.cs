using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ConnectionManager : IFactoryConnection
    {
        public Conexion GetConnection(string motor)
        {
            switch (motor)
            {
                case "SQL":
                    return new SQLConnection();
                    
                case "MYSQL":
                    return new MySQLConnection();
            }

            return new SQLConnection();
        }

        public string GetConnection(Conexion connection)
        {
            return connection.ToString();
        }

        public bool Autenticar(ISecurity connection)
        {
            ((Conexion)connection).Conectar();
            return connection.Autenticar();
        }
    }
}
