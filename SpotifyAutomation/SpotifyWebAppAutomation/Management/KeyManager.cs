namespace SpotifyWebAppAutomation.Management
{
    namespace RestSharpSpot.Miscellaneous
    {
        public class KeyManager
        {
            public KeyManager()
            {
                ObtainKey();
            }

            public string Key { get; set; }

            private void ObtainKey()
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\michal.krupej\Documents\SpotifyApiAutomation\SpotifyAutomation\SpotifyWebAppAutomation\Key.txt");
                var line = "";

                while ((line = file.ReadLine()) != null)
                {
                    this.Key = line;
                }
            }
        }
    }
}
