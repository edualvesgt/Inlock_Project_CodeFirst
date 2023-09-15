using Microsoft.AspNetCore.Mvc;
using webApi.Inlock.CodeFirst.Interfaces;
using webApi.Inlock.CodeFirst.Repositories;
using webApi.Inlock.CodeFirst.ViewModels;

namespace webApi.Inlock.CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                LoginViewModel user = new LoginViewModel();
                user = _usuarioRepository.BuscarUsuario(usuario.Senha, usuario.Email);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
