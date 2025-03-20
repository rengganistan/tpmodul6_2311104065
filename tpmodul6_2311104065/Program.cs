using tpmodul6_2311104065;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Membuat objek video
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rengganis Tantri Pramudita");
            video.PrintVideoDetails();

            // Uji penambahan play count
            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();

            // Uji batas maksimal play count (dengan looping untuk cepat mencapai overflow)
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
