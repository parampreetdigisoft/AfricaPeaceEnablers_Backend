using AfricaPeaceEnablers.Dtos.CommonDto;
using AfricaPeaceEnablers.Models;

namespace AfricaPeaceEnablers.Dtos.kpiDto
{
    public class GetAnalyticalLayerRequestDto : PaginationRequest
    {
        public int? CountryID { get; set; }
        public int? LayerID { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
    }
}
