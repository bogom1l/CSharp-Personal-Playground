namespace SOLIDDemo.Open_Closed
{
    public class Progress
    {
        private readonly IResult _result;

        public Progress(IResult result)
        {
            this._result = result;
        }

        public int CurrentPercent()
        {
            return _result.Sent * 100 / _result.Length;
        }
    }
}