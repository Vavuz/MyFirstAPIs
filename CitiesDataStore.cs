using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Verona",
                    Description = "City with the Arena.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 11,
                            Name = "Arena di Verona",
                            Description = "A big Arena built before the Colosseum."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 12,
                            Name = "Piazza Dante",
                            Description = "A beautiful square that celebrates Dante Alighieri."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Bergamo",
                    Description = "City with high and low city.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 21,
                            Name = "Bergamo Tower",
                            Description = "A tower next to the motorway with a Bergamo sign on it."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 22,
                            Name = "High City",
                            Description = "The half of Bergamo build on a hill."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Edinburgh",
                    Description = "Capital of Scotland.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 31,
                            Name = "Edinburgh Castle",
                            Description = "A beautiful castle that stands on the top of the Royal Mile."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 32,
                            Name = "Calton Hill",
                            Description = "An hill with a lovely view on Edinburgh."
                        }
                    }
                }
            };
        }
    }
}
