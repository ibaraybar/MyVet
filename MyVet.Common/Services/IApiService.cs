using MyVet.Common.Models;
using System.Threading.Tasks;

namespace MyVet.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetOwnerByEmailAsync(
            string urlBase,
            string servicePrefix,
            string controller,
            string tokenType,
            string accessToken,
            string email);

        Task<Response> GetTokenAsync(
            string urlBase,
            string servicePrefix,
            string controller,
            TokenRequest request);
    }

}
