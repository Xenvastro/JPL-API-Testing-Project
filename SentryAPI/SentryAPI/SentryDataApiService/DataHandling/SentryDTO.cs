﻿using Newtonsoft.Json;


namespace JPL_API_Testing.SentryAPI.SentrydesDataApiService.DataHandling
{
    public class SentryDTO
    {

        public SentryRoot SentryData { get; set; }

        public spkRoot spkData { get; set; }

        public desRoot desData { get; set; }

        public void DeserialiseSentryData(string SentryResponse)
        {
            SentryData = JsonConvert.DeserializeObject<SentryRoot>(SentryResponse);
        }

        public void DeserialiseSentryDataspk(string SentryResponse)
        {
            spkData = JsonConvert.DeserializeObject<spkRoot>(SentryResponse);
        }
        public void DeserialiseSentryDatades(string SentryResponse)
        {
            desData = JsonConvert.DeserializeObject<desRoot>(SentryResponse);
        }
    }
}