﻿namespace RestSharpSpot.Api.Objects
{
    public class RecommendationSeed
    {
        public int AfterFilteringSize { get; set; }
        public int AfterRelinkingSize { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public int InitialPoolSize { get; set; }
        public string Type { get; set; }
    }
}