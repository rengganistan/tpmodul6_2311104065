using tpmodul6_2311104065;
class Program
{
    static void Main(string[] args)
    {
        try
        {

            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rengganis Tantri Pramudita");
            video.PrintVideoDetails();

            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();

            video.IncreasePlayCount(10000000);
            video.PrintVideoDetails();

            video.IncreasePlayCount(20000000);

            for (int i = 0; i < 1000; i++)
            {
                video.IncreasePlayCount(10000000);
            }

            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
