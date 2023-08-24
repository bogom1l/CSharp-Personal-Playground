namespace AsyncAwaitDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Ivaylo Kenov - Asynchronous Processing Lecture:
            //https://www.youtube.com/live/m5-hYdj40So?si=0qPraHJR8SA3jOUE

            await AsyncCooker.Work();
        }
    }
}