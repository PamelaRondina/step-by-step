using SimpleInjector;
using SimpleInjector.Integration.Web;
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;
using Pam.Business.Core.Notificacoes;
using Pam.Business.Models.Fornecedores.Services;
using Pam.Business.Models.Fornecedores;
using Pam.Business.Models.Produtos.Services;
using Pam.Business.Models.Produtos;
using Pam.Infra.Data.Context;
using Pam.Infra.Data.Repository;
using Pam.AppMvc.App_Start;

namespace Pam.AppMvc
{
    public class DependencyInjectionConfig
    {

        public static void RegisterDIContainer()
        {
            /*Definir o Container*/
            var container = new Container();

            /*Definir o LifeStyle -SCOPED WEB Aplicação Web*/
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);
            
            /*Definir as Controllers para validar se estão configuradas corretamente*/
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            /*DepenencyResolver: Classe do MVC, vai passar a instância (SetResolver) para o container*/
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        /*Método InitializeContainer para configurar objetos: Repository, Service, Mapper*/
        private static void InitializeContainer(Container container)
        {
            container.Register<MeuDbContext>(Lifestyle.Scoped);
            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);
            container.Register<IFornecedorRepository, FornecedorRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);            
            container.Register<IFornecedorService, FornecedorService>(Lifestyle.Scoped);
            container.Register<INotificador, Notificador>(Lifestyle.Scoped);

            /*Está como SINGLETON*/
            container.RegisterSingleton(() => AutoMapperConfig.GetMapperConfiguration().CreateMapper(container.GetInstance));

        }
    }
}