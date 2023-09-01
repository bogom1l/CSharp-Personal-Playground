namespace SOLIDDemo.Open_Closed
{
    public class Music : IResult
    {
        public Music(string artist, string album, int length, int sent)
        {
            Artist = artist;
            Album = album;
            Length = length;
            Sent = sent;
        }

        public string Artist { get; set; }

        public string Album { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}