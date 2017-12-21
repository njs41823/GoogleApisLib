using System.Collections.Generic;

namespace GoogleApisLib.Models.MapsDistanceMatrix
{
    public enum Units
    {
        NotSpecified,
        Metric,
        Imperial
    }

    public enum Mode
    {
        NotSpecified,
        Driving,
        Walking,
        Bicycling,
        Transit
    }

    public enum TransitMode
    {
        NotSpecified,
        Bus,
        Subway,
        Train,
        Tram,
        Rail
    }

    public enum TrafficModel
    {
        NotSpecified,
        BestGuess,
        Optimistic,
        Pessimistic
    }

    public enum Avoid
    {
        NotSpecified,
        Ferries,
        Highways,
        Indoor,
        Tolls
    }

    public enum TransitRoutingPreference
    {
        NotSpecified,
        FewerTransfers,
        LessWalking
    }

    public enum Language
    {
        NotSpecified,
        Arabic,
        Basque,
        Bengali,
        Bulgarian,
        Catalan,
        ChineseSimplified,
        ChineseTraditional,
        Croatian,
        Czech,
        Danish,
        Dutch,
        English,
        EnglishAustralian,
        EnglishGreatBritain,
        Farsi,
        Filipino,
        Finnish,
        French,
        Galician,
        German,
        Greek,
        Gujarati,
        Hebrew,
        Hindi,
        Hungarian,
        Indonesian,
        Italian,
        Japanese,
        Kannada,
        Korean,
        Latvian,
        Lithuanian,
        Malayalam,
        Marathi,
        Norwegian,
        Polish,
        Portuguese,
        PortugueseBrazil,
        PortuguesePortugal,
        Romanian,
        Russian,
        Serbian,
        Slovak,
        Slovenian,
        Spanish,
        Swedish,
        Tagalog,
        Tamil,
        Telugu,
        Thai,
        Turkish,
        Ukrainian,
        Vietnamese
    }

    public static class DisplayStringDictionaries
    {
        public static readonly Dictionary<Mode, string> ModeDisplayStrings =  new Dictionary<Mode, string>
        {
            { Mode.NotSpecified, "Not Specified" },
            { Mode.Bicycling, "Bicycling" },
            { Mode.Driving, "Driving" },
            { Mode.Transit, "Transit" },
            { Mode.Walking, "Walking" }
        };
        
        public static readonly Dictionary<Language, string> LanguageDisplayStrings =  new Dictionary<Language, string>
        {
            { Language.NotSpecified, "Not Specified" },
            { Language.Arabic, "Arabic" },
            { Language.Basque, "Basque" },
            { Language.Bengali, "Bengali" },
            { Language.Bulgarian, "Bulgarian" },
            { Language.Catalan, "Catalan" },
            { Language.ChineseSimplified, "Chinese (Simplified)" },
            { Language.ChineseTraditional, "Chinese (Traditional)" },
            { Language.Croatian, "Croatian" },
            { Language.Czech, "Czech" },
            { Language.Danish, "Danish" },
            { Language.Dutch, "Dutch" },
            { Language.English, "English" },
            { Language.EnglishAustralian, "English (Australian)" },
            { Language.EnglishGreatBritain, "English (Great Britain)" },
            { Language.Farsi, "Farsi" },
            { Language.Filipino, "Filipino" },
            { Language.Finnish, "Finnish" },
            { Language.French, "French" },
            { Language.Galician, "Galician" },
            { Language.German, "German" },
            { Language.Greek, "Greek" },
            { Language.Gujarati, "Gujarati" },
            { Language.Hebrew, "Hebrew" },
            { Language.Hindi, "Hindi" },
            { Language.Hungarian, "Hungarian" },
            { Language.Indonesian, "Indonesian" },
            { Language.Italian, "Italian" },
            { Language.Japanese, "Japanese" },
            { Language.Kannada, "Kannada" },
            { Language.Korean, "Korean" },
            { Language.Latvian, "Latvian" },
            { Language.Lithuanian, "Lithuanian" },
            { Language.Malayalam, "Malayam" },
            { Language.Marathi, "Marathi" },
            { Language.Norwegian, "Norwegian" },
            { Language.Polish, "Polish" },
            { Language.Portuguese, "Portuguese" },
            { Language.PortugueseBrazil, "Portuguese (Brazil)" },
            { Language.PortuguesePortugal, "Portuguese (Portugal)" },
            { Language.Romanian, "Romanian" },
            { Language.Russian, "Russian" },
            { Language.Serbian, "Serbian" },
            { Language.Slovak, "Slovak" },
            { Language.Slovenian, "Slovenian" },
            { Language.Spanish, "Spanish" },
            { Language.Swedish, "Swedish" },
            { Language.Tagalog, "Tagalog" },
            { Language.Tamil, "Tamil" },
            { Language.Telugu, "Telugu" },
            { Language.Thai, "Thai" },
            { Language.Turkish, "Turkish" },
            { Language.Ukrainian, "Ukrainian" },
            { Language.Vietnamese, "Vietnamese" }
        };
        
        public static readonly Dictionary<Avoid, string> AvoidDisplayStrings =  new Dictionary<Avoid, string>
        {
            { Avoid.NotSpecified, "Not Specified" },
            { Avoid.Ferries, "Ferries" },
            { Avoid.Highways, "Highways" },
            { Avoid.Indoor, "Indoor" },
            { Avoid.Tolls, "Tolls" }
        };

        
        public static readonly Dictionary<Units, string> UnitsDisplayStrings =  new Dictionary<Units, string>
        {
            { Units.NotSpecified, "Not Specified" },
            { Units.Imperial, "Imperial" },
            { Units.Metric, "Metric" }
        };
        
        public static readonly Dictionary<TrafficModel, string> TrafficModelDisplayStrings =  new Dictionary<TrafficModel, string>
        {
            { TrafficModel.NotSpecified, "Not Specified" },
            { TrafficModel.BestGuess, "Best Guess" },
            { TrafficModel.Optimistic, "Optimistic" },
            { TrafficModel.Pessimistic, "Pessimistic" }
        };
        
        public static readonly Dictionary<TransitMode, string> TransitModeDisplayStrings =  new Dictionary<TransitMode, string>
        {
            { TransitMode.NotSpecified, "Not Specified" },
            { TransitMode.Bus, "Bus" },
            { TransitMode.Rail, "Rail" },
            { TransitMode.Subway, "Subway" },
            { TransitMode.Train, "Train" },
            { TransitMode.Tram, "Tram" }
        };
        
        public static readonly Dictionary<TransitRoutingPreference, string> TransitRoutingPreferenceDisplayStrings =  new Dictionary<TransitRoutingPreference, string>
        {
            { TransitRoutingPreference.NotSpecified, "Not Specified" },
            { TransitRoutingPreference.FewerTransfers, "Fewer Transfers" },
            { TransitRoutingPreference.LessWalking, "Less Walking" }
        };
    }

    public static class RequestStringDictionaries
    {
        private const string ModeParameter = "&mode=";
        public static readonly Dictionary<Mode, string> ModeRequestStrings = new Dictionary<Mode, string>
        {
            { Mode.NotSpecified, string.Empty },
            { Mode.Bicycling, ModeParameter + "bicycling" },
            { Mode.Driving, ModeParameter + "driving" },
            { Mode.Transit, ModeParameter + "transit" },
            { Mode.Walking, ModeParameter + "walking" }
        };

        private const string LanguageParameter = "&language=";
        public static readonly Dictionary<Language, string> LanguageRequestStrings = new Dictionary<Language, string>
        {
            { Language.NotSpecified, string.Empty },
            { Language.Arabic, LanguageParameter + "ar" },
            { Language.Basque, LanguageParameter + "eu" },
            { Language.Bengali, LanguageParameter + "bn" },
            { Language.Bulgarian, LanguageParameter + "bg" },
            { Language.Catalan, LanguageParameter + "ca" },
            { Language.ChineseSimplified, LanguageParameter + "zh-CN" },
            { Language.ChineseTraditional, LanguageParameter + "zh-TW" },
            { Language.Croatian, LanguageParameter + "hr" },
            { Language.Czech, LanguageParameter + "cs" },
            { Language.Danish, LanguageParameter + "da" },
            { Language.Dutch, LanguageParameter + "nl" },
            { Language.English, LanguageParameter + "en" },
            { Language.EnglishAustralian, LanguageParameter + "en-AU" },
            { Language.EnglishGreatBritain, LanguageParameter + "en-GB" },
            { Language.Farsi, LanguageParameter + "fa" },
            { Language.Filipino, LanguageParameter + "fil" },
            { Language.Finnish, LanguageParameter + "fi" },
            { Language.French, LanguageParameter + "fr" },
            { Language.Galician, LanguageParameter + "gl" },
            { Language.German, LanguageParameter + "de" },
            { Language.Greek, LanguageParameter + "el" },
            { Language.Gujarati, LanguageParameter + "gu" },
            { Language.Hebrew, LanguageParameter + "iw" },
            { Language.Hindi, LanguageParameter + "hi" },
            { Language.Hungarian, LanguageParameter + "hu" },
            { Language.Indonesian, LanguageParameter + "id" },
            { Language.Italian, LanguageParameter + "it" },
            { Language.Japanese, LanguageParameter + "ja" },
            { Language.Kannada, LanguageParameter + "kn" },
            { Language.Korean, LanguageParameter + "ko" },
            { Language.Latvian, LanguageParameter + "lv" },
            { Language.Lithuanian, LanguageParameter + "lt" },
            { Language.Malayalam, LanguageParameter + "ml" },
            { Language.Marathi, LanguageParameter + "mr" },
            { Language.Norwegian, LanguageParameter + "no" },
            { Language.Polish, LanguageParameter + "pl" },
            { Language.Portuguese, LanguageParameter + "pt" },
            { Language.PortugueseBrazil, LanguageParameter + "pt-BR" },
            { Language.PortuguesePortugal, LanguageParameter + "pt-PT" },
            { Language.Romanian, LanguageParameter + "ro" },
            { Language.Russian, LanguageParameter + "ru" },
            { Language.Serbian, LanguageParameter + "sr" },
            { Language.Slovak, LanguageParameter + "sk" },
            { Language.Slovenian, LanguageParameter + "sl" },
            { Language.Spanish, LanguageParameter + "es" },
            { Language.Swedish, LanguageParameter + "sv" },
            { Language.Tagalog, LanguageParameter + "tl" },
            { Language.Tamil, LanguageParameter + "ta" },
            { Language.Telugu, LanguageParameter + "te" },
            { Language.Thai, LanguageParameter + "th" },
            { Language.Turkish, LanguageParameter + "tr" },
            { Language.Ukrainian, LanguageParameter + "uk" },
            { Language.Vietnamese, LanguageParameter + "vi" }
        };

        private const string AvoidParameter = "&avoid=";
        public static readonly Dictionary<Avoid, string> AvoidRequestStrings = new Dictionary<Avoid, string>
        {
            { Avoid.NotSpecified, string.Empty },
            { Avoid.Ferries, AvoidParameter + "ferries" },
            { Avoid.Highways, AvoidParameter + "highways" },
            { Avoid.Indoor, AvoidParameter + "indoor" },
            { Avoid.Tolls, AvoidParameter + "tolls" }
        };


        private const string UnitsParameter = "&units=";
        public static readonly Dictionary<Units, string> UnitsRequestStrings = new Dictionary<Units, string>
        {
            { Units.NotSpecified, string.Empty },
            { Units.Imperial, UnitsParameter + "imperial" },
            { Units.Metric, UnitsParameter + "metric" }
        };

        private const string TrafficModelParameter = "&traffic_model=";
        public static readonly Dictionary<TrafficModel, string> TrafficModelRequestStrings = new Dictionary<TrafficModel, string>
        {
            { TrafficModel.NotSpecified, string.Empty },
            { TrafficModel.BestGuess, TrafficModelParameter + "best_guess" },
            { TrafficModel.Optimistic, TrafficModelParameter + "optimistic" },
            { TrafficModel.Pessimistic, TrafficModelParameter + "pessimistic" }
        };

        private const string TransitModeParameter = "&transit_mode=";
        public static readonly Dictionary<TransitMode, string> TransitModeRequestStrings = new Dictionary<TransitMode, string>
        {
            { TransitMode.NotSpecified, string.Empty },
            { TransitMode.Bus, TransitModeParameter + "bus" },
            { TransitMode.Rail, TransitModeParameter + "rail" },
            { TransitMode.Subway, TransitModeParameter + "subway" },
            { TransitMode.Train, TransitModeParameter + "train" },
            { TransitMode.Tram, TransitModeParameter + "tram" }
        };

        private const string TransitRoutingPreferenceParameter = "&transit_routing_preference=";
        public static readonly Dictionary<TransitRoutingPreference, string> TransitRoutingPreferenceRequestStrings = new Dictionary<TransitRoutingPreference, string>
        {
            { TransitRoutingPreference.NotSpecified, string.Empty },
            { TransitRoutingPreference.FewerTransfers, TransitRoutingPreferenceParameter + "fewer_transfers" },
            { TransitRoutingPreference.LessWalking, TransitRoutingPreferenceParameter + "less_walking" }
        }; 
    }
}
