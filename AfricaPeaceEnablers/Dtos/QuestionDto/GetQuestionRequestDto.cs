using AfricaPeaceEnablers.Dtos.CommonDto;

namespace AfricaPeaceEnablers.Dtos.QuestionDto
{
    public class GetQuestionRequestDto : PaginationRequest
    {
        public int? PillarID { get; set; }
    }
}
