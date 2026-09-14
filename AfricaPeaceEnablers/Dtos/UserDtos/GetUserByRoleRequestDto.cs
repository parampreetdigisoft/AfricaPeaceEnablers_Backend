using AfricaPeaceEnablers.Dtos.CommonDto;
using AfricaPeaceEnablers.Models;

namespace AfricaPeaceEnablers.Dtos.UserDtos
{
    public class GetUserByRoleRequestDto : PaginationRequest
    {
        public UserRole? GetUserRole { get; set; }
        public int UserID { get; set; }
    }
}
