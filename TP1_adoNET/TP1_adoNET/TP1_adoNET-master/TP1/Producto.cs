using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TP1
{

        public class Producto
        {
            public int Id { get; set; }        
            public string Nombre { get; set; }
            public decimal Precio { get; set; } 
        }

}
