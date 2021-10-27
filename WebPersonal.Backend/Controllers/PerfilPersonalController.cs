using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPersonal.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Para que nuestro controlador acepte ser una api ; Debe contener ApiController
    // ; ApiController como atributo de la clase
    public class PerfilPersonalController : ControllerBase //Los controladores deben de heredar de ControllerBase || Controller
    {

        //Leer datos de una api
        //[HttpGet("LeerPerfil/{id}")]//Establecemos atributo con el metodo
        [HttpGet("{id}")]
        // ; Ademas podemos poner la ruta para el metodo y tambien le pasamos el id que queremos leer
        public string Get(int id)
        {
            return id switch
            {
                1 => "Carlos",
                2 => "Obed",
                _ => throw new NotSupportedException("el id no es valido")
            };
        }


        //[HttpPost]//Importante poner el metodo http que usara        
        //public string Post(PerfilPersonalDto perfilPersonal)//Ahora Metodo POST
        //{


        //    //Guardar perfil en la base de datos
        //    return perfilPersonal.Nombre;

        //}

        public PerfilPersonalDto Post(PerfilPersonalDto perfilPersonal)//Ahora Metodo POST
        {
            //Guardar perfil en la base de datos
            return perfilPersonal; //Retorna objeto
        }
    }

    public class PerfilPersonalDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
