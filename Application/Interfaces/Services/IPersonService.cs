using Application.Commands.Persons;
using Application.Common.Models;
using Application.Common.Response.Persons;
using Shared.Results;

namespace Application.Interfaces.Services
{
    public interface IPersonService
    {
        Task<ResultOfT<PagedResult<PersonResponse>>> SearchPagedAsync(SearchParams searchParams, CancellationToken cancellationToken = default);
        Task<ResultOfT<PersonResponse>> GetAsync(string value, CancellationToken cancellationToken = default);
        Task<ResultOfT<PersonResponse>> CreateAsync(CreatePersonCommand command, CancellationToken cancellationToken = default);
        Task<ResultOfT<PersonResponse>> UpdateAsync(UpdatePersonCommand command, CancellationToken cancellationToken = default);
        Task<Result> DeleteAsync(string value, CancellationToken cancellationToken = default);
    }
}
