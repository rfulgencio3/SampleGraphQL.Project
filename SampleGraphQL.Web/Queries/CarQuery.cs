using SampleGraphQL.Web.Models;
using SampleGraphQL.Web.Services.Interface;

namespace SampleGraphQL.Web.Queries
{
    public class CarQuery
    {
        ICarService _carService;
        public CarQuery(ICarService carService)
        {
            _carService = carService;
        }

        public List<Car> Cars => _carService.GetCars();
    }
}
