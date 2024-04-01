using System.Xml.Linq;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogError("Error parsing line: Insufficient data");
                return null; 
            }

            // TODO: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double latitude;
            if (!double.TryParse(cells[0], out latitude))
            {
                // Log error message and return null if parsing fails
                logger.LogError("Error parsing latitude");
                return null;
            }


            // TODO: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double longitude;
            if (!double.TryParse(cells[1], out longitude))
            {
                // Log error message and return null if parsing fails
                logger.LogError("Error parsing longitude");
                return null;
            }


            // TODO: Grab the name from your array at index 2
            string name = cells[2];

            // TODO: Create a TacoBell class
            // that conforms to ITrackable

            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude) 


            var location = new Point();
            location.Latitude = latitude;
            location.Longitude = longitude;

            // TODO: Create an instance of the TacoBell class
            var tacoBell = new TacoBell();
            // TODO: Set the values of the class correctly (Name and Location)
            tacoBell.Name = name;
            tacoBell.Location = location;

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return tacoBell;
        }
    }
}
