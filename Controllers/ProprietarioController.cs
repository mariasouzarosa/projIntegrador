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
    public class ProprietarioController : ControllerBase
    {
        private BDContexto contexto;
        
        public ProprietarioController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
        
        [HttpGet]
        public List<Proprietario> Listar()
        {
            return contexto.Proprietario.ToList();
        }
    
    
        [HttpGet]
        public List<Proprietario> OrdenarCrescente()
        {
            return contexto.Proprietario.OrderBy(c => c.Nome).Select
            (
                c => new Proprietario 
                { 
                    CpfProp = c.CpfProp,
                    Nome = c.Nome,
                    Telefone = c.Telefone
                }).ToList();
        }

    
        [HttpGet]
        public List<Proprietario> OrdenarDecrescente()
        {
            return contexto.Proprietario.OrderByDescending(c => c.Nome).Select
            (
                c => new Proprietario 
                { 
                    CpfProp = c.CpfProp,
                    Nome = c.Nome,
                    Telefone = c.Telefone
                }).ToList();
        }
    
    }

}