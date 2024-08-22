using Practice9_EFCore.Domain.Models;

namespace Practice9_EFCore.Contracts
{
    public record BuildingsResponse(
        Guid Id,
        string Address,
        double XPosition,
        double YPosition);
}
