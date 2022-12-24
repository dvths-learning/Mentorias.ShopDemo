using ErrorOr;

namespace McbEdu.Mentorias.ShopDemo.Domain.Common.Errors;

public static partial class Errors
{
    public static class Customer
    {
        public static Error EmailAlreadyExists => Error.Conflict(
            code: "Customer.EmailAlreadyExists",
            description: "The registration attempt failed because a customer with the same email exists in the database.");
    }
}