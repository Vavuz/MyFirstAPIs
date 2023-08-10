using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Verona",
                    Description = "City with the Arena."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Bergamo",
                    Description = "City with high and low city."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Edinburgh",
                    Description = "Capital of Scotland."
                }
            };
        }
    }
}
