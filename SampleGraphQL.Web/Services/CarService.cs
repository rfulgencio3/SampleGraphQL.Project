using SampleGraphQL.Web.Models;
using SampleGraphQL.Web.Services.Interface;

namespace SampleGraphQL.Web.Services
{
    public class CarService : ICarService
    {
        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            return cars;
        }
    }
}
