using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Scopes
{
    public class EntidadeGameScopes : AbstractValidator<EntidadeGame>
    {
        public EntidadeGameScopes()
        {         
            Include(new EntidadeGameCampoGuidEhValido());
            Include(new EntidadeGameCampoTituloEhValido());
            Include(new EntidadeGameCampoAnoEhValido());            
        }

        public bool EhValido(EntidadeGame campo)
        {
            var result = Validate(campo);

            if (result.IsValid) return true;

            foreach (var failure in result.Errors)
            {
               // implementar o sistema que recebe e dispara as mensagens de erro quando a validação não estiver em conformidade
            }

            return false;
        }
    }

    internal class EntidadeGameCampoGuidEhValido : AbstractValidator<EntidadeGame>
    {
        internal EntidadeGameCampoGuidEhValido()
        {
            const string property = "O campo Guid de identificação do registro";
            RuleFor(x => x.EntidadeGameGuid)
                .NotEmpty().WithMessage($"{property} não pode ser vazio!")
                .NotNull().WithMessage($"{property} não pode ser nulo!")
                .NotEqual(Guid.Empty).WithMessage($"{property} não pode ser vazio!");
        }
    }

    internal class EntidadeGameCampoTituloEhValido : AbstractValidator<EntidadeGame>
    {
        internal EntidadeGameCampoTituloEhValido()
        {
            const string property = "O campo Titulo  do registro";
            RuleFor(x => x.titulo)
                .NotEmpty().WithMessage($"{property} não pode ser vazio!")
                .NotNull().WithMessage($"{property} não pode ser nulo!");
        }
    }

    internal class EntidadeGameCampoAnoEhValido : AbstractValidator<EntidadeGame>
    {
        internal EntidadeGameCampoAnoEhValido()
        {
            const string property = "O campo Ano do registro";
            RuleFor(x => x.ano)
                .NotEmpty().WithMessage($"{property} não pode ser vazio!")
                .NotNull().WithMessage($"{property} não pode ser nulo!")
                .GreaterThan(0).WithMessage($"{property} não pode ser menor que zero!");
        }
    }
}
