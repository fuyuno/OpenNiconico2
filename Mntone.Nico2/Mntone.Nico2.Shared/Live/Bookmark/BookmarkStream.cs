using System;
using System.Runtime.Serialization;

namespace Mntone.Nico2.Live.Bookmark
{
    [DataContract]
    public class BookmarkStream
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        public DateTime StartTime { get; set; }

        [DataMember(Name = "start_time")]
        private string _startTime { get; set; }

        [DataMember(Name = "_communityinfo")]
        public CommunityInfo CommunityInfo { get; set; }

        [DataMember(Name = "isTimeshift")]
        public bool IsTimeshift { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            StartTime = DateTime.Parse(_startTime);
        }
    }
}