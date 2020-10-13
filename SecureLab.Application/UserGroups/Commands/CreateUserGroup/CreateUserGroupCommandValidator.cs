using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.UserGroups.Commands.CreateUserGroup
{
    class CreateUserGroupCommandValidator : AbstractValidator<CreateUserGroupCommand>
    {
        public CreateUserGroupCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
        }
    }
}
