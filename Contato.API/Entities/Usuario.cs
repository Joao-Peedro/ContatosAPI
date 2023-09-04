using Contato.API.Enums;

namespace Contato.API.Entities;

public class Usuario
{
	public int Id { get; set; }
	public string? Login { get; set; }
	public string? SenhaHash { get; set; }
	public EnumTipoUsuario EnumTipoUsuario { get; set; }
}
