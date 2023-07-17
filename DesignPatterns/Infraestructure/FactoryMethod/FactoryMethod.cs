using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;
using DesignPatterns.Repositories;

namespace DesignPatterns.Infraestructure.FactoryMethod
{
    public class FactoryMethod
    {
        private readonly IVehicleRepository _vehicleRepository;
        public abstract class VehicleFactory
        {
            public abstract IVehicle CreateVehicle();
        }

        public class MustangFactory : VehicleFactory
        {
            public override IVehicle CreateVehicle()
            {
                var builder = new CarBuilder();
                
                return new Car("Red", "Ford", "Mustang");
            }
        }

        public class ExplorerFactory : VehicleFactory
        {
            public override IVehicle CreateVehicle()
            {
                return new Car("Blue", "Ford", "Explorer");
            }
        }

    }
}
