using Contato.API.Entities;
using Contato.API.Helpers;
using Contato.API.Repositories.Interfaces;
using Dapper;
using System.Data;

namespace Contato.API.Repositories.Implementacoes;

public class ContatoRepository : IContatoRespository
{
	private readonly IDataContext _dataContext;

	public ContatoRepository(IDataContext dataContext)
	{
		_dataContext = dataContext;
	}

	public async Task Atualize(ContatoEntitie contato)
	{
		using IDbConnection conexao = _dataContext.CrieConexao();
		string sql = @"UPDATE Contatos SET Nome = @Nome, Email = @Email, Telefone = @Telefone WHERE Id = @Id";
		await conexao.ExecuteAsync(sql, contato);
	}

	public async Task Delete(int id)
	{
		using IDbConnection conexao = _dataContext.CrieConexao();
		string sql = "DELETE FROM Contatos WHERE Id = @id";
		await conexao.ExecuteAsync(sql, new { id });
	}

	public async Task<ContatoEntitie> ObtenhaPorId(int id)
	{
		using IDbConnection conexao = _dataContext.CrieConexao();
		string sql = "SELECT Id, Nome, Email, Telefone FROM Contatos WHERE Id = @id";
		return await conexao.QuerySingleOrDefaultAsync<ContatoEntitie>(sql, new { id });
	}

	public async Task<IEnumerable<ContatoEntitie>> ObtenhaTodos()
	{
		using IDbConnection conexao = _dataContext.CrieConexao();
		string sql = "SELECT Id, Nome, Email, Telefone FROM Contatos";
		return await conexao.QueryAsync<ContatoEntitie>(sql);
	}

	public async Task RegistreContato(ContatoEntitie contato)
	{
		using IDbConnection conexao = _dataContext.CrieConexao();
		string sql = "INSERT INTO Contatos (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";
		await conexao.ExecuteAsync(sql, contato);
	}
}
