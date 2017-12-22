using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApisLib.MapsDistanceMatrixApi.Models
{
    public class ApiRequest
    {
        private const string JsonApiRootEndpoint = "https://maps.googleapis.com/maps/api/distancematrix/json?";

        public ApiRequest(string apiKey)
        {
            Key = apiKey;
        }

        public const int MaxElementsPerRequest = 100;

        public List<string> Origins { get; set; } = new List<string>();

        public List<string> Destinations { get; set; } = new List<string>();

        public Mode Mode { get; set; } = Mode.NotSpecified;

        public Language Language { get; set; } = Language.NotSpecified;

        public Avoid Avoid { get; set; } = Avoid.NotSpecified;

        public Units Units { get; set; } = Units.NotSpecified;

        public DateTime? ArrivalTime { get; set; } = null;

        public DateTime? DepartureTime { get; set; } = null;

        public TrafficModel TrafficModel { get; set; } = TrafficModel.NotSpecified;

        public TransitMode TransitMode { get; set; } = TransitMode.NotSpecified;

        public TransitRoutingPreference TransitRoutingPreference { get; set; } = TransitRoutingPreference.NotSpecified;
        
        public string Key { get; }

        public string RequestString
        {
            get
            {
                const string locationDelimiter = "|";
                DateTime baseDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                string originsString = "&origins=" + string.Join(locationDelimiter, Origins).Replace(" ", "+");
                string destinationsString = "&destinations=" + string.Join(locationDelimiter, Destinations).Replace(" ", "+").Replace("%", string.Empty);
                string modeString = RequestStringDictionaries.ModeRequestStrings[Mode];
                string languageString = RequestStringDictionaries.LanguageRequestStrings[Language];
                string avoidString = RequestStringDictionaries.AvoidRequestStrings[Avoid];
                string unitsString = RequestStringDictionaries.UnitsRequestStrings[Units];
                string arrivalTimeString = ArrivalTime == null ? string.Empty : "&arrival_time=" + Math.Floor((((DateTime)ArrivalTime).ToUniversalTime() - baseDateTime).TotalSeconds);
                string departureTimeString = DepartureTime == null ? string.Empty : "&departure_time=" + Math.Floor((((DateTime)DepartureTime).ToUniversalTime() - baseDateTime).TotalSeconds);
                string trafficModelString = RequestStringDictionaries.TrafficModelRequestStrings[TrafficModel];
                string transitModeString = RequestStringDictionaries.TransitModeRequestStrings[TransitMode];
                string transitRoutingPreferenceString = RequestStringDictionaries.TransitRoutingPreferenceRequestStrings[TransitRoutingPreference];
                string keyString = "&key=" + Key;

                return
                    JsonApiRootEndpoint + originsString + destinationsString +
                    modeString + languageString + avoidString + unitsString + arrivalTimeString + departureTimeString +
                    trafficModelString + transitModeString + transitRoutingPreferenceString + keyString;
            }
        }
        
        public async Task<ApiResponse> GetDistanceMatrixAsync()
        {
            ApiResponse result = null;
            await Task.Run(() =>
            {
                if (!(WebRequest.Create(RequestString) is HttpWebRequest httpRequest)) throw new HttpRequestException("Failed to create HttpWebRequest");
                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();
                Encoding encoding = Encoding.ASCII;
                using (StreamReader reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(), encoding))
                {
                    string responseText = reader.ReadToEnd();
                    result = ApiResponse.CreateFromJson(responseText);
                    result.RequestString = RequestString;
                    result.ResponseJson = responseText;
                }
            });
            return result;
        }
    }
}
