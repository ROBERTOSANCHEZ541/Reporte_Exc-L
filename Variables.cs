using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte_Exc_L
{
    internal class Variables
    {
        public string Query;
        public int i;
        public SqlConnection conexion = new SqlConnection("data source=DESKTOP-6ECTDJR\\SQLEXPRESS; initial catalog=Capacitacion; integrated security=SSPI; persist security info=false; trusted_connection=yes;");     
    }
}
