namespace IEvangelist.VideoChat.Options
{
    public class TwilioSettings
    {
        /// <summary>
        /// The primary Twilio account SID, displayed prominently on your twilio.com/console dashboard.
        /// </summary>
       // public string AccountSid { get; set; }
        public string AccountSid = "AC46f25608174d43140c4721fc348ec85c";

        /// <summary>
        /// Signing Key SID, also known as the API SID or API Key.
        /// </summary>
        public string ApiKey = "SK6611519893e8639ba89358bcd20782de";

        /// <summary>
        /// The API Secret that corresponds to the <see cref="ApiKey"/>.
        /// </summary>
        public string ApiSecret = "bIgyQwrYi8hSaRAnCWhfXAmtOnC6d3kz";
    }
}