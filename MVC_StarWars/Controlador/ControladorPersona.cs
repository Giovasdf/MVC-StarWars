using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorPersona
    {

        public static bool AgregarPersona(string nombre, bool isJedi)
        {
            return AgregarPersonaLista(nombre,isJedi);       
        }

        public static bool AgregarPersona(ModeloPersona persona)
        {
            return AgregarPersonaLista(persona);
        }

        #region SobreCarga AgregarLista
        private static bool AgregarPersonaLista(string nombre, bool isJedi)
        {
            try
            {
                ModeloPersona.Singleton.AgregarPersona(nombre, isJedi);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        private static bool AgregarPersonaLista(ModeloPersona persona)
        {
            try
            {
                ModeloPersona.Singleton.AgregarPersona(persona);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        #endregion SobreCarga AgregarLista
    }
}
