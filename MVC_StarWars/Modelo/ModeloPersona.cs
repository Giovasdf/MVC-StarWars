using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public sealed class ModeloPersona
    {

        public string Nombre { get; set; }
        public bool isJedi { get; set; }

        static ModeloPersona instancia;
        //Lista Interna
        static List<ModeloPersona> _personas = new List<ModeloPersona>();
        //Lista Externa solo puede retornar lista interna
        public List<ModeloPersona> personas { get { return _personas; } }
        //Ocultar Constructor
        private ModeloPersona() { }
        
        public static ModeloPersona Singleton
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new ModeloPersona();
                }
                return instancia;
            }
        }

        public void AgregarPersona(ModeloPersona persona)
        {
            _personas.Add(persona);
        }
        public void AgregarPersona(string nombre, bool isJedi)
        {
            ModeloPersona persona = new ModeloPersona();
            persona.Nombre = nombre;
            persona.isJedi = isJedi;
            _personas.Add(persona);
        }

    }
}
