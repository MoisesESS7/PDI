namespace Shared.Results
{
    public sealed class ResultOfT<T> : Result
    {
        public T? Value { get; }

        private ResultOfT(bool isSuccess, T? value, Error? error) : base (isSuccess, error)
        {
            Value = value;
        }

        public static ResultOfT<T> Ok(T value) => new (true, value, null);
        public static new ResultOfT<T> Fail(Error error) => new (false, default, error);
    }
}
