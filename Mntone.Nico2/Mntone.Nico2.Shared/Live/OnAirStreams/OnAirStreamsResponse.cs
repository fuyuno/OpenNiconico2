using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Mntone.Nico2.Live.OnAirStreams
{
    /// <summary>
    ///     放送中の番組を格納するクラス
    /// </summary>
    [DataContract]
    public sealed class OnAirStreamsResponse
    {
        private List<OnAirStream> _OnAirStreams;
        private List<ReservedStream> _ReservedStreams;

        /// <summary>
        ///     放送中の番組の一覧
        /// </summary>
        public IReadOnlyList<OnAirStream> OnAirStreams
        {
            get { return _OnAirStreams; }
        }

        [DataMember(Name = "onair_stream_list")]
        private List<OnAirStream> OnAirStreamsImpl
        {
            get { return _OnAirStreams ?? (_OnAirStreams = new List<OnAirStream>()); }
            set { _OnAirStreams = value; }
        }

        /// <summary>
        ///     予約している放送中の番組一覧 (index のみ)
        /// </summary>
        public IReadOnlyList<ReservedStream> ReservedStreams
        {
            get { return _ReservedStreams; }
        }

        [DataMember(Name = "reserved_stream_list")]
        private List<ReservedStream> ReservedStreamsImpl
        {
            get { return _ReservedStreams ?? (_ReservedStreams = new List<ReservedStream>()); }
            set { _ReservedStreams = value; }
        }
    }
}