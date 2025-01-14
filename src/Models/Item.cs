﻿using System.Text.Json.Serialization;
//using Newtonsoft.Json;

namespace todo.Models
{
    public class Item
    {
        //[JsonProperty(PropertyName = "id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        //[JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        //[JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        //[JsonProperty(PropertyName = "isComplete")]
        public bool Completed { get; set; }
    }
}
