namespace Attentio.Infrastructure.Models
{
    public interface IResultInfo
    {
        bool Succeed { get; set; }
        string Message { get; set; }
    }

    public interface IResultInfo<T> : IResultInfo
    {
        T Data { get; set; }
    }
}
