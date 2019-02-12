using System.Collections.Generic;

namespace RestSharpSpot.Api.Model.AudioAnalysis
{
    public class AudioAnalysis
    {
        public List<TimeInterval> Bars { get; set; }
        public List<TimeInterval> Beats { get; set; }
        public List<Section> Sections { get; set; }
        public List<Segment> Segments { get; set; }
        public List<TimeInterval> Tatums { get; set; }
    }
}