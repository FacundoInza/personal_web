using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebPersonal.BackEnd.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PerfilPersonalController : ControllerBase
  {
    [HttpGet("{id}")]
    public string Get(int id)
    {

      return id switch
      {
        1 => "Ivan",
        2 => "Curso",
        _ => throw new NotSupportedException("el id no es valido")
      }
      ;
    }

    public string Post(PerfilPersonalDto perfilPersonal)
    {
      return perfilPersonal.Nombre;
    }

  }

  public class PerfilPersonalDto
  {
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }

  }
}