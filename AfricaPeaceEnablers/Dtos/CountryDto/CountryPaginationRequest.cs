using AfricaPeaceEnablers.Dtos.CommonDto;

namespace AfricaPeaceEnablers.Dtos.CountryDto
{
    public class CountryPaginationRequest: PaginationRequest
    {
        public int? CountryID { get; set; }
    }
}
