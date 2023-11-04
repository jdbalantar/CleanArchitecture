using FluentValidation;

namespace CleanArchitecture.Application.Features.Directors.Commands.CreateDirector
{
    public class CreateDirectorCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateDirectorCommandValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().NotNull();
            RuleFor(x => x.Apellido).NotEmpty().NotNull();
        }
    }
}
