﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Documents;
using Newtonsoft.Json;

namespace CompetitionDb.Models
{
    public class appCompetition
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "competitors")]
        public appCompetitors Competitors { get; set; }
    }
}