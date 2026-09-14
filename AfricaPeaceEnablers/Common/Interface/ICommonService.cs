using AfricaPeaceEnablers.Common.Models;
using AfricaPeaceEnablers.Dtos.CountryDto;
using AfricaPeaceEnablers.Dtos.PillarDto;
using AfricaPeaceEnablers.Models;

namespace AfricaPeaceEnablers.Common.Interface
{
    public interface ICommonService
    {
        Task<List<EvaluationCountryProgressResultDto>> GetCountriesProgressAsync(int userId,int role, int year,int countryID = 0);
        Task<List<EvaluationCountryProgressHistoryResultDto>> GetCountriesProgressHistoryAsync(int userId, int role, int fromYear, int toYear);
        Task<List<GetCountriesProgressAdminDto>> GetCountriesProgressForAdmin(int userId, int role, int year);
        Task<List<CountryRankingResultDto>> GetCountriesRankings(int countryId, int year);
        Task<List<GetPillarDto>> GetPillars();
        void ClearPillarCache();
        Task<ResultResponseDto<bool>> RevokeCountriesPermission(List<int> countryIds, int userID, int year);

    }
}
