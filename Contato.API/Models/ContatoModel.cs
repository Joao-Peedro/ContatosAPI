using System.ComponentModel.DataAnnotations;

namespace Contato.API.Models;

public class ContatoModel
{
	public string? Nome { get; set; }

	[EmailAddress]
	public string? Email { get; set; }

	public string? Telefone { get; set; }
}
