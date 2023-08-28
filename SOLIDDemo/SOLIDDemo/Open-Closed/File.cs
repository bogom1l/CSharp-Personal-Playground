namespace SOLIDDemo.Open_Closed
{
    public class File : IResult
    {
        public File(string name, int length, int sent)
        {
            Name = name;
            Length = length;
            Sent = sent;
        }

        public string Name { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}