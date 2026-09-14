using AfricaPeaceEnablers.Common.Models;
using AfricaPeaceEnablers.Dtos.CountryUserDto;

namespace AfricaPeaceEnablers.IServices
{
    public interface ISignalDashboardService
    {
        Task<ResultResponseDto<PeaceStressTestDashboardDto>> GetPeaceStressTestDashboard(int countryID, int year, int userId);
        Task<ResultResponseDto<EarlyWarningDashboardDto>> GetEarlyWarningDashboard(int countryID, int year, int userId);
        Task<ResultResponseDto<ResilienceScorecardDto>> GetResilienceScorecard(int countryID, int year, int userId);
    }
}
