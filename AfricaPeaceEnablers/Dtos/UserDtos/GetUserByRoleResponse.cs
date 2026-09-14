using AfricaPeaceEnablers.Dtos.CountryDto;

namespace AfricaPeaceEnablers.Dtos.UserDtos
{
    public class GetUserByRoleResponse : PublicUserResponse
    {
        public List<AddUpdateCountryDto> Countries { get; set; } = new();
    }
}
