using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities/{cityId}/pointsofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            return (city == null ? NotFound() : Ok(city.PointsOfInterest));
        }

        [HttpGet("{pointOfInterestId}")]
        public ActionResult<PointOfInterestDto> GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city != null)
            {
                var pointOfInterest = city.PointsOfInterest.FirstOrDefault(c => c.Id == pointOfInterestId);

                if (pointOfInterest != null)
                    return Ok(pointOfInterest);
            }
            return NotFound();
        }
    }
}
