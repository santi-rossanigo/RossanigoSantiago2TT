using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1;

public class RepositorioProductos
    {
        public string connectionString = "Data Source=RCAL1306P40-111;Initial Catalog=TiendaDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";


        public void Agregar(Producto p)
        {
            string sql = "INSERT INTO Productos(Nombre, Precio) VALUES (@Nombre, @Precio)";
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

 
        public List<Producto> Listar()
        {
            var lista = new List<Producto>();
            string sql = "SELECT Id, Nombre, Precio FROM Productos";
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var prod = new Producto
                        {
                            Id = dr.GetInt32(0),
                            Nombre = dr.GetString(1),
                            Precio = dr.GetDecimal(2)
                        };
                        lista.Add(prod);
                    }
                }
            }
            return lista;
        }

   
        public void Modificar(Producto p)
        {
            string sql = "UPDATE Productos SET Nombre=@Nombre, Precio=@Precio WHERE Id=@Id";
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@Id", p.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void Eliminar(int id)
        {
            string sql = "DELETE FROM Productos WHERE Id=@Id";
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }






