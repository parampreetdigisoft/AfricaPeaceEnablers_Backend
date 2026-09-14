using AfricaPeaceEnablers.Common.Models;
using AfricaPeaceEnablers.Dtos.CommonDto;
using AfricaPeaceEnablers.Dtos.CountryUserDto;
using AfricaPeaceEnablers.Dtos.kpiDto;
using AfricaPeaceEnablers.Enums;
using AfricaPeaceEnablers.Models;

namespace AfricaPeaceEnablers.IServices
{
    public interface IKpiService
    {
        Task<PaginationResponse<GetAnalyticalLayerResultDto>> GetAnalyticalLayerResults(GetAnalyticalLayerRequestDto request, int userId, UserRole role, TieredAccessPlan userPlan = TieredAccessPlan.Pending);
        Task<ResultResponseDto<List<AnalyticalLayer>>> GetAllKpi(int userId, UserRole role);
        Task<ResultResponseDto<List<AnalyticalLayerPillarMappingDto>>> GetKPIDetailsByLayerID(IReadOnlyCollection<int> layerIds);
        Task<ResultResponseDto<CompareCountryResponseDto>> CompareCountries(CompareCountryRequestDto c, int userId, UserRole role, bool applyPagination = true);

        Task<Tuple<string, byte[]>> ExportCompareCountries(CompareCountryRequestDto request, int userId, UserRole role);
        Task<ResultResponseDto<GetMutiplekpiLayerResultsDto>> GetMutiplekpiLayerResults(GetMutiplekpiLayerRequestDto request, int userId, UserRole role, TieredAccessPlan userPlan = TieredAccessPlan.Pending);
        Task<ResultResponseDto<SummarizeKpiResponseDto>> SummarizeKpiPerformance(SummarizeKpiRequestDto request, int userId, UserRole role);

    }
}
