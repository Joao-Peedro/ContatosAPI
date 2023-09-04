using Contato.API.Enums;

namespace Contato.API.Models;

public class UsuarioModel
{
	public string? Login { get; set; }
	public string? Senha { get; set; }
	public EnumTipoUsuario EnumTipoUsuario { get; set; }
}
