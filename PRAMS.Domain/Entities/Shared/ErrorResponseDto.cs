namespace PRAMS.Domain.Entities.Shared
{
    public class ErrorResponseDto<TValue> : ResponseDto<TValue>
    {
        public override bool IsSuccess { get; set; } = false;
    }
}
