using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFizzBuzz" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFizzBuzz
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/FizzBuzz/{Number}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string DoFizzBuzz(string Number);
    }
}
