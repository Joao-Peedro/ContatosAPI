using Contato.API.Entities;

namespace Contato.API.Repositories.Interfaces
{
	public interface IContatoRespository
	{
		Task RegistreContato(ContatoEntitie contato);
		Task<IEnumerable<ContatoEntitie>> ObtenhaTodos();
		Task<ContatoEntitie> ObtenhaPorId(int id);
		Task Atualize(ContatoEntitie contato);
		Task Delete(int id);
	}
}
