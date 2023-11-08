using ErrorOr;

namespace CleanProject.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: "User.Duplicated",
            description: "Email is alreday in use."
        );
    }
}