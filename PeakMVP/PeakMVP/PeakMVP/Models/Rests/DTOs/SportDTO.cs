﻿using Newtonsoft.Json;

namespace PeakMVP.Models.Rests.DTOs {
    public class SportDTO {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
