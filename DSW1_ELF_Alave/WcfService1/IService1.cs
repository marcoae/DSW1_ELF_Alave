using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract] List<Cliente> Clientes();

        [OperationContract] List<Pais> Paises();
    
        [OperationContract] List<Pedidoscabe> Pedidoscabexyear(int y);
        [OperationContract] List<Pedidoscabe> Pedidoscabexcliente(String cliente);
         



        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]

    public class Cliente
    {
        [DataMember] public string IdCliente { get; set; }
        [DataMember] public string NombreCia { get; set; }
        [DataMember] public string Direccion { get; set; }
        [DataMember] public string Idpais { get; set; }
        [DataMember] public string Telefono { get; set; }
    }
    public class Pais
    {
        [DataMember] public string IdPais { get; set; }
        [DataMember] public string NombrePais { get; set; }
      

    }

    public class Pedidoscabe
    {
        [DataMember] public int IdPedido { get; set; }
        [DataMember] public DateTime FechaPedido { get; set; }
        [DataMember] public string clientepedido { get; set; }
        [DataMember] public string DireccionDestinatario { get; set; }
        [DataMember] public string empleadoPedido { get; set; }
    }
  
public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
