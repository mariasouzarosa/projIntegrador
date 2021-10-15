using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projetoTeste.Models;
 
namespace projetoTeste.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private BDContexto contexto;
        
        public MunicipioController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
        
        [HttpGet]
        public List<Municipio> Listar()
        {
            return contexto.Municipio.ToList();
        }
    }
}