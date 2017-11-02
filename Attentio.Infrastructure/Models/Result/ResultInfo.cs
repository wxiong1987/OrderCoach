namespace Attentio.Infrastructure.Models
{
    public class ResultInfo : IResultInfo
    {
        public bool Succeed { get; set; }
        public string Message { get; set; }
        public int Value { get; set; }

        public ResultInfo()
        {
        }

        public ResultInfo(bool sSucceed)
            : this(sSucceed, null)
        {
        }

        public ResultInfo(bool isSucceed, string message)
        {
            this.Succeed = isSucceed;
            this.Message = message;
        }

        public ResultInfo(bool isSucceed, string message, int value)
        {
            this.Succeed = isSucceed;
            this.Message = message;
            this.Value = value;
        }
    }

    public class ResultInfo<T> : ResultInfo, IResultInfo<T>
    {
        public ResultInfo()
        {
        }

        public ResultInfo(bool isSucceed)
            : this(isSucceed, null)
        {
        }

        public ResultInfo(bool isSucceed, string message)
            : base(isSucceed, message)
        {
        }

        public ResultInfo(bool isSucceed, string message, int value)
            : base(isSucceed, message, value)
        {
        }

        public T Data { get; set; }
    }
}
