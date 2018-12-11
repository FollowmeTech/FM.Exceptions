namespace FM.Exceptions
{
    public class ErrorCode
    {
        /// <summary>Not an error; returned on success.</summary>
        public const int Ok = 0;

        /// <summary>
        /// 未知异常
        /// </summary>
        public const int Unknown = 1;

        /// <summary>
        /// 无效参数
        /// </summary>
        public const int InvalidArgument = 3;

        /// <summary>
        /// 权限拒绝
        /// </summary>
        public const int PermissionDenied = 7;

        /// <summary>
        /// 未认证
        /// </summary>
        public const int Unauthenticated = 16;
    }
}
