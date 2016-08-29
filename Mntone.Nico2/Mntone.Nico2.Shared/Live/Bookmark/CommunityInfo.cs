using System.Runtime.Serialization;

namespace Mntone.Nico2.Live.Bookmark
{
    [DataContract]
    public class CommunityInfo
    {
        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; set; }
    }
}