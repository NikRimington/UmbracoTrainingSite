using Newtonsoft.Json;
using System;

namespace TrainingSite.Models
{
    public class EventFilterModel
    {
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
    }

    public class EventListModel
    {

    }
}