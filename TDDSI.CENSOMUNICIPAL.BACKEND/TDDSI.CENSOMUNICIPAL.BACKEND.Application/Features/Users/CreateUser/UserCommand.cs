using System.ComponentModel.DataAnnotations;
using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.Users.CreateUser;
public record UserCommand(
    [Required] string FirstName
    , string? SecondName
    , [Required] string SurName
    , string? SecondSurName
    ) : ICommand<UserCommandResponse>;
