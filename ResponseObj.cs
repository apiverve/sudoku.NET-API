using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class puzzle
{
    [JsonProperty("grid")]
    public string grid { get; set; }

    [JsonProperty("html")]
    public string html { get; set; }

}

public class solution
{
    [JsonProperty("grid")]
    public string grid { get; set; }

    [JsonProperty("html")]
    public string html { get; set; }

}

public class data
{
    [JsonProperty("puzzle")]
    public puzzle puzzle { get; set; }

    [JsonProperty("solution")]
    public solution solution { get; set; }

    [JsonProperty("difficulty")]
    public string difficulty { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
