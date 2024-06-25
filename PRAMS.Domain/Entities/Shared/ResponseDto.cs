namespace PRAMS.Domain.Entities.Shared
{
    public class ResponseDto<TValue>
    {
        public TValue? Result { get; set; }
        public virtual bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
