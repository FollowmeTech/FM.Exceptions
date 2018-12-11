namespace FM.Exceptions
{
    /// <summary>
    /// 多系统中间rpc error中的detailjson 实体
    /// </summary>
    public class Error
    {
        public int Code { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Internal { get; set; }
        public string Content { get; set; }
    }
}
