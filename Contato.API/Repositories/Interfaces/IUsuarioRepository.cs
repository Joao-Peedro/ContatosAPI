using Contato.API.Entities;

namespace Contato.API.Repositories.Interfaces;

public interface IUsuarioRepository
{
	Task RegistreUsuario(Usuario usuario);
	Task<Usuario> ConsulteLogin(string login, string senhaHash);
}
