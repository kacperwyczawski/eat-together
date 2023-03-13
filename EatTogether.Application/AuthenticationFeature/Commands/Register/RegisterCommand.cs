using EatTogether.Application.AuthenticationFeature.Common;
using ErrorOr;
using MediatR;

namespace EatTogether.Application.AuthenticationFeature.Commands.Register;

public record RegisterCommand(
    string Email, 
    string Password, 
    string FirstName, 
    string LastName) : IRequest<ErrorOr<AuthenticationResult>>;