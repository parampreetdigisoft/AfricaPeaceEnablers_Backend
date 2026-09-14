using AfricaPeaceEnablers.Common.Models;
using AfricaPeaceEnablers.Dtos.AiDto;
using AfricaPeaceEnablers.Dtos.AssessmentDto;
using AfricaPeaceEnablers.Dtos.CountryDto;
using AfricaPeaceEnablers.Dtos.CommonDto;
using AfricaPeaceEnablers.Dtos.kpiDto;
using AfricaPeaceEnablers.Dtos.PublicDto;
using AfricaPeaceEnablers.Enums;
using AfricaPeaceEnablers.Models;
using AfricaPeaceEnablers.Dtos.CountryUserDto;

namespace AfricaPeaceEnablers.IServices
{
    public interface ICountryUserService
    {
        Task<List<Pillar>> GetAllAsync(int userId, UserRole userRole);
        Task<ResultResponseDto<List<PartnerCountryResponseDto>>> GetCountryUserCountries(int userID);
        Task<ResultResponseDto<CountryHistoryDto>> GetCountryHistory(int userId, TieredAccessPlan tier);
        Task<ResultResponseDto<List<GetCountriesSubmitionHistoryResponseDto>>> GetCountriesProgressByUserId(int userID);
        Task<GetCountryQuestionHistoryResponseDto> GetCountryQuestionHistory(UserCountryRequestDto userCountryRequstDto);
        Task<PaginationResponse<CountryResponseDto>> GetCountriesAsync(PaginationRequest request);
        Task<ResultResponseDto<CountryDetailsDto>> GetCountryDetails(UserCountryRequestDto userCountryRequstDto);
        Task<ResultResponseDto<List<CountryPillarQuestionDetailsDto>>> GetCountryPillarDetails(UserCountryGetPillarInfoRequestDto userCountryGetPillarInfoRequestDto);
        Task<ResultResponseDto<string>> AddCountryUserKpisCountryAndPillar(AddCountryUserKpisCountryAndPillar payload,int userID, string tierName);
        Task<ResultResponseDto<List<GetAllKpisResponseDto>>> GetCountryUserKpi(int userID, string tierName);
        Task<ResultResponseDto<CompareCountryResponseDto>> CompareCountries(CompareCountryRequestDto c, int userId, string tierName, bool applyPagination = true);
        Task<ResultResponseDto<AiCountryPillarResponseDto>> GetAICountryPillars(AiCountryPillarRequestDto r, int userID, string tierName);
        Task<Tuple<string, byte[]>> ExportCompareCountries(CompareCountryRequestDto request, int userId, string tierName);
    }
}
