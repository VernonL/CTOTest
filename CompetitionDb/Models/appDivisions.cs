using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Documents;
using Newtonsoft.Json;

namespace CompetitionDb.Models
{
    public class appDivisions
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "agegroup")]
        public string AgeGroup { get; set; }

        [JsonProperty(PropertyName = "place")]
        public Award Place { get; set; }
    }

    public class Award
    {
        [JsonProperty(PropertyName = "first")]
        public bool First { get; set; }

        [JsonProperty(PropertyName = "second")]
        public bool Second { get; set; }

        [JsonProperty(PropertyName = "third")]
        public bool Third { get; set; }
    }
}