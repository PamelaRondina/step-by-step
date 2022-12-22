using AutoMapper;
using Pam.AppMvc.ViewModels;
using Pam.Business.Models.Fornecedores;
using Pam.Business.Models.Produtos;
using System;
using System.Linq;
using System.Reflection;

namespace Pam.AppMvc.App_Start
{
    /* Classe para ativar o AutoMapper*/
    public class AutoMapperConfig
    {
        /*Config para encontrar qualquer classe que herde de Profile edo AutoMapper*/ 
        public static MapperConfiguration GetMapperConfiguration()
        {
            /*Coleção que herdam de Profile
             var profile onde através do objeto Assembly, na inicialização do projeto pega todos os Assemblys executados | 
             GetTyoe = vai obter os tipos deles
            Onde os tipos são do tipo Profile | E se está atribuido*/
            var profiles = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });

        }
    }
        /*classe de que herda do Profile do AutoMapper*/
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            /*mapear das entidades para viewModel e ReverseMap(vice e versa)*/
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }    
}