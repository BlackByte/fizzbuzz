using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "FizzBuzz" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione FizzBuzz.svc o FizzBuzz.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class FizzBuzz : IFizzBuzz
    {
        private int max = 100;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string DoFizzBuzz(string number)
        {
            log.Info("Numero introducido: " + number);
            string tmp = "";
            string fizzBuzzResponse = "";
            try
            {
                int value = Convert.ToInt32(number);
                if (value > 100)
                {
                    log.Warn("Nº inferior");
                    throw new Exception("El numero introducido supera el limite disponible, pruebe de nuevo con un numeor inferior a 100");
                }
                for (int i = value; i <= this.max; i++ )
                {
                   if (i % 3 == 0)
                    {
                        tmp = "Fizz";
                    }
                   if (i % 5 == 0)
                    {
                        tmp += "Buzz";
                    }
                    if (String.Empty == tmp)
                    {
                        tmp = i.ToString();
                    }
                    fizzBuzzResponse = fizzBuzzResponse + tmp + ",";
                    tmp = "";
                }
            }

            catch (FormatException e)
            {
                log.Error("Valor Erroneo");
                return "El valor introducido no es un numero" + e.ToString();
            }
            catch (Exception e)
            {
                log.Error("Error en " + e.ToString());
                return e.ToString();
            }
            return fizzBuzzResponse;
        }
    }
}
