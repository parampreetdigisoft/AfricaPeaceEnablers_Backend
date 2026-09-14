using AfricaPeaceEnablers.Common.Models;
using AfricaPeaceEnablers.Dtos.AssessmentDto;
using AfricaPeaceEnablers.Dtos.CommonDto;
using AfricaPeaceEnablers.Dtos.UserDtos;
using AfricaPeaceEnablers.Models;

namespace AfricaPeaceEnablers.IServices
{
    public interface IUserService
    {
        User GetByEmail(string email);
        Task<PaginationResponse<GetUserByRoleResponse>> GetUserByRoleWithAssignedCountry(GetUserByRoleRequestDto requestDto, int userid, UserRole userRole);
        Task<ResultResponseDto<List<PublicUserResponse>>> GetEvaluatorByAnalyst(GetAssignUserDto requestDto);
        Task<ResultResponseDto<List<GetAssessmentResponseDto>>> GetUsersAssignedToCountry(int countryId);
        Task<ResultResponseDto<UpdateUserResponseDto>> GetUserInfo(int userId);

    }
} 