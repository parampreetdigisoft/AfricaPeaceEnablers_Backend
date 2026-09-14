

using AfricaPeaceEnablers.Dtos.AiDto;
using AfricaPeaceEnablers.Models;
using static AfricaPeaceEnablers.Services.AIComputationService;

namespace AfricaPeaceEnablers.Common.Interface
{
    public interface IPdfGeneratorService
    {
        Task<byte[]> GenerateCountryDetailsPdf(AiCountrySummeryDto country, List<AiCountryPillarResponse> pillars, List<KpiChartItem> kpis, List<PeerCountryHistoryReportDto> peercountry, UserRole userRole);
        Task<byte[]> GeneratePillarDetailsPdf(AiCountryPillarResponse countryDetails, UserRole userRole);
        Task<byte[]> GenerateAllCountriesDetailsPdf(List<AiCountrySummeryDto> countries, Dictionary<int, List<AiCountryPillarResponse>> pillars, List<KpiChartItem> kpis, UserRole userRole);
    }
}
