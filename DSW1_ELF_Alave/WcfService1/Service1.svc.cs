using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.cnx);

        
        public List<Cliente> Clientes()
        {
            return ListaClientes().ToList();
        }

   
        public List<Pais> Paises()
        {
            throw new NotImplementedException();
        }
       
        public List<Pedidoscabe> Pedidoscabexcliente(string cliente)
        {
            return ListaPedidos().Where(p => p.clientepedido == cliente).ToList();

          }

            public List<Pedidoscabe> Pedidoscabexyear(int y)
        {
            return ListaPedidos().Where(p => p.FechaPedido.Year == y).ToList();
        }

        public List<Cliente> ListaClientes()
        {
            List<Cliente> lista = new List<Cliente> { };
            SqlCommand cmd = new SqlCommand("pa_listaclientes", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente reg = new Cliente();
                reg.IdCliente = dr["IdCliente"].ToString();
                reg.NombreCia = dr["NombreCia"].ToString();
                reg.Direccion = dr["Direccion"].ToString();
                reg.Idpais = dr["NombrePais"].ToString();
                reg.Telefono = dr["Telefono"].ToString();
                lista.Add(reg);

            }
            dr.Close();
            cn.Close();
            return lista;
        }

        public List<Pedidoscabe> ListaPedidos()

        {
            List<Pedidoscabe> lista = new List<Pedidoscabe> { };
            SqlCommand cmd = new SqlCommand("pa_pedidosCliente", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidoscabe reg = new Pedidoscabe();
                reg.IdPedido = (int)dr["IdPedido"];
                reg.FechaPedido = (DateTime)dr["FechaPedido"];
                reg.clientepedido = dr["NombreCia"].ToString();
                reg.DireccionDestinatario = dr["DireccionDestinatario"].ToString();
                reg.empleadoPedido = dr["ApeEmpleado"].ToString();
                lista.Add(reg);
            }
            dr.Close();
            cn.Close();

            return lista;

        }

    }
}
