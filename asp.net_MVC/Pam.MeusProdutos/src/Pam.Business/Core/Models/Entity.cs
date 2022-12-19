using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pam.Business.Core.Models
{
    //Classe mãe!
    public abstract class Entity
    {
        // os membros protegidos só podem ser acessíveis de quem herdar   
        protected Entity()
        { 
            //O Id será acessado pela numeração do NewGuid
            Id = Guid.NewGuid();
        }
        
        // Guid: gera numeração não sequencial como o "Int ID"
        // Dá para definir o ID da entidade antes de salvar no BD
        public Guid Id { get; set; }

    }
      
}
