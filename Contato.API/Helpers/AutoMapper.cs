using AutoMapper;
using Contato.API.Entities;
using Contato.API.Models;

namespace Contato.API.Helpers;

public class AutoMapper : Profile
{
	public AutoMapper()
	{
		CreateMap<UsuarioModel, Usuario>();
		CreateMap<ContatoModel, ContatoEntitie>();
	}
}
