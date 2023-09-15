using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using webApi.Inlock.CodeFirst.Domains;
using webApi.Inlock.CodeFirst.Interfaces;
using webApi.Inlock.CodeFirst.Repositories;

namespace webApi.Inlock.CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Post (Usuario user)
        {
            try
            {
                _usuarioRepository.Cadastrar(user);

                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]

        public IActionResult Get(int id)
        {

        }
    }
}
