using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Image data
    /// </summary>
    public class Image
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("downloadURL")]
        public string DownloadURL { get; set; }

        [JsonProperty("expires")]
        public int Expires { get; set; }

    }
    /// <summary>
    /// Puzzle data
    /// </summary>
    public class Puzzle
    {
        [JsonProperty("grid")]
        public string Grid { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

    }
    /// <summary>
    /// Solution data
    /// </summary>
    public class Solution
    {
        [JsonProperty("grid")]
        public string Grid { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("puzzle")]
        public Puzzle Puzzle { get; set; }

        [JsonProperty("solution")]
        public Solution Solution { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
