using System.Drawing;


namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitmap memoryImage;

            while (true)
            {
                Console.WriteLine("Press Enter for Screenshot");

                var key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter)
                {
                    continue;
                }
                memoryImage = new Bitmap(2200, 1200);

                Size size = new Size(memoryImage.Width, memoryImage.Height);

                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Screenshots");
                using Graphics graphics = Graphics.FromImage(memoryImage);

                graphics.CopyFromScreen(0, 0, 0, 0, size);

                string fileName = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Screenshots" + @"\Screenshot" + "_" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png");

                memoryImage.Save(fileName);

                Console.WriteLine("Picture saved");
            }
        }
    }
}