using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Mntone.Nico2.Live.Bookmark
{
    [DataContract]
    public class BookmarkResponse
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "totalPages")]
        public int TotalPages { get; set; }

        [DataMember(Name = "bookmarkStreams")]
        public List<BookmarkStream> BookmarkStreams { get; set; }
    }
}