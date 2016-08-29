using System;
using System.Runtime.Serialization;

namespace Mntone.Nico2.Live.OnAirStreams
{
    /// <summary>
    ///     予約した放送中の番組情報を格納するクラス
    /// </summary>
    [DataContract]
    public sealed class ReservedStream
    {
        /// <summary>
        ///     ?
        /// </summary>
        [DataMember(Name = "gauge_level")]
        public ushort GaugeLevel { get; private set; }

        /// <summary>
        ///     リストに表示しないか
        /// </summary>
        [DataMember(Name = "hide_zapping")]
        public bool IsHidden { get; private set; }

        /// <summary>
        ///     ID
        /// </summary>
        public string Id { get; private set; } = string.Empty;

        [DataMember(Name = "id")]
        private string IdImpl
        {
            get { return (Id != null) && (Id.Length > 2) ? Id.Substring(2) : null; }
            set { Id = "lv" + value; }
        }

        /// <summary>
        ///     Nsen 番組か
        /// </summary>
        [DataMember(Name = "is_nsen")]
        public bool IsNsen { get; private set; }

        /// <summary>
        ///     製品番組か
        /// </summary>
        [DataMember(Name = "is_product")]
        public bool IsProduct { get; private set; }

        /// <summary>
        ///     ザッピング モードが有効か
        /// </summary>
        [DataMember(Name = "is_zapping_mode_enabled")]
        public bool IsZappingModeEnabled { get; private set; }

        /// <summary>
        ///     開場時間
        /// </summary>
        public DateTimeOffset OpenedAt { get; private set; } = DateTimeOffset.MinValue;

        [DataMember(Name = "open_time")]
        private long OpenedAtImpl
        {
            get { return OpenedAt.ToLongFromDateTimeOffset(); }
            set { OpenedAt = value.ToDateTimeOffsetFromUnixTime(); }
        }

        /// <summary>
        ///     小さいサムネール URL
        /// </summary>
        [DataMember(Name = "thumbnail_small_url")]
        public Uri SmallThumbnailUrl { get; private set; }

        /// <summary>
        ///     題名
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; private set; }
    }
}