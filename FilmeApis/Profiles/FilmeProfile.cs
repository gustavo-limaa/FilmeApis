using AutoMapper;
using FilmeApis.Data.Dtos;
using FilmeApis.Models;

namespace FilmeApis.Profiles;

public class FilmeProfile : Profile 
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDtos, Filme>();
        CreateMap<UpdateFilmeDTO, Filme>();
        CreateMap<Filme, UpdateFilmeDTO>();
        CreateMap<Filme, ReadFilmeDto>();



    }
}
