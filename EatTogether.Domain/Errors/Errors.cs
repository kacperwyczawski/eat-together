using ErrorOr;

namespace EatTogether.Domain.Errors;

public static class Errors
{
    public static class User
    {
        public static Error DuplicateEmail =>
            Error.Conflict(description: "User with this email already exists. Please use another email.");
    }

    public static class Authentication
    {
        public static Error InvalidCredentials =>
            Error.Validation(description: "Invalid credentials. Please check your email and password.");
    }
}