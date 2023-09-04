using Contato.API.Models;

namespace Contato.API.Services.Interfaces;

public interface IUsuarioService
{
	Task RegistreUsuario(UsuarioModel usuarioModel);

	Task<string?> RealizeLogin(LoginModel loginModel);
}
