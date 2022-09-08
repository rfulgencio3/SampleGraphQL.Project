using SampleGraphQL.Web.Models;

namespace SampleGraphQL.Web.Services.Interface
{
    public interface ICarService
    {
        List<Car> GetCars();
    }
}
