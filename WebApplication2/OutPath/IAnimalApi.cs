//<auto-generated />

using System.Threading.Tasks;
using Refit;
using WebApplication2;

namespace My.Client.Namespace
{
    public partial interface IAnimalApi
    {
        [Put("/Animal")]
        Task<Animal> Put([Body(BodySerializationMethod.UrlEncoded)] AnimalRequest animal = null);
    }
}