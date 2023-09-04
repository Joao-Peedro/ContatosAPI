using Contato.API.Entities;
using Contato.API.Models;

namespace Contato.API.Services.Interfaces;

public interface IContatoService
{
	Task RegistreContato(ContatoModel contatoModel);
	Task<IEnumerable<ContatoEntitie>> ObtenhaTodos();
	Task<ContatoEntitie> ObtenhaPorId(int id);
	Task Atualize(int id, ContatoModel contatoModel);
	Task Delete(int id);
}
