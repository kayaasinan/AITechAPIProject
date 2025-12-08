using AITech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AITech.WebUI.Validators.ProjectValidators
{
    public class UpdateProjectValidator : AbstractValidator<UpdateProjectDto>
    {
        public UpdateProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş bırakılamaz")
                                        .MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        }
    }
}
