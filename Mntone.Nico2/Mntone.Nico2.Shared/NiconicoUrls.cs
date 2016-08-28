namespace Mntone.Nico2
{
    /// <summary>
    ///     ニコニコに関する URL 群
    /// </summary>
    public static class NiconicoUrls
    {
        private const string DomainBase = ".nicovideo.jp/";

        private const string LiveApiForCommunityUrlBase = "http://watch.live.nicovideo.jp/api/";
        private const string LiveApiForOfficialOrChannelUrlBase = "http://ow.live.nicovideo.jp/api/";
        private const string LiveApiForExternalUrlBase = "http://ext.live.nicovideo.jp/api/";

        /// <summary>
        ///     ニコニコ トップ ページ URL テキスト
        /// </summary>
        public static string TopPageUrl => VideoUrlBase;

        #region Authentication

        private const string AuthenticationBase = "https://secure" + DomainBase + "secure/";

        internal static string LogOnUrl => AuthenticationBase + "login?site=niconico";
        internal static string LogOffUrl => "https://account.nicovideo.jp/logout?site=niconico";

        #endregion

        #region Videos

        private const string VideoUrlBase = "http://www" + DomainBase;
        private const string VideoApiUrlBase = VideoUrlBase + "api/";
        private const string VideoFlapiUrlBase = "http://flapi" + DomainBase + "api/";

        /// <summary>
        ///     ニコニコ動画 トップ ページ URL テキスト
        /// </summary>
        public static string VideoTopPageUrl => VideoUrlBase + "my/top";

        /// <summary>
        ///     ニコニコ動画 マイ ページ URL テキスト
        /// </summary>
        public static string VideoMyPageUrl => VideoUrlBase + "video_top";

        /// <summary>
        ///     ニコニコ動画 視聴ページ URL テキスト
        /// </summary>
        public static string VideoWatchPageUrl => VideoUrlBase + "watch/";

        internal static string VideoFlvUrl => VideoFlapiUrlBase + "getflv/";

        internal static string VideoThumbInfoUrl => "http://ext.nicovideo.jp/api/getthumbinfo/";

        internal static string VideoHistoryUrl => VideoApiUrlBase + "videoviewhistory/list";

        internal static string VideoRemoveUrl => VideoApiUrlBase + "videoviewhistory/remove?token=";

        #endregion

        #region Live

        private const string LiveUrlBase = "http://live" + DomainBase;
        private const string LiveApiUrlBase = LiveUrlBase + "api/";

        /// <summary>
        ///     ニコニコ生放送 トップ ページ URL テキスト
        /// </summary>
        public static string LiveTopPageUrl => LiveUrlBase;

        /// <summary>
        ///     ニコニコ生放送 マイ ページ URL テキスト
        /// </summary>
        public static string LiveMyPageUrl => LiveUrlBase + "my";

        /// <summary>
        ///     ニコニコ生放送 視聴ページ URL テキスト
        /// </summary>
        public static string LiveWatchPageUrl => LiveUrlBase + "watch/";

        /// <summary>
        ///     ニコニコ生放送 ゲート ページ URL テキスト
        /// </summary>
        public static string LiveGatePageUrl => LiveUrlBase + "gate/";

        internal static string LiveCKeyUrl => LiveApiUrlBase + "getckey";

        internal static string LivePlayerStatusUrl => LiveApiUrlBase + "getplayerstatus/";

        internal static string LivePostKeyUrl => LiveApiUrlBase + "getpostkey";

        internal static string LiveVoteUrl => LiveApiUrlBase + "vote";

        internal static string LiveHeartbeatUrl => LiveApiUrlBase + "heartbeat";

        internal static string LiveLeaveUrl => LiveApiUrlBase + "leave";

        internal static string LiveTagRevisionUrl => LiveApiUrlBase + "tagrev/";

        internal static string LiveZappingListIndexUrl => LiveApiUrlBase + "getzappinglist?zroute=index";

        internal static string LiveZappingListRecentUrl => LiveApiUrlBase + "getzappinglist?zroute=recent";

        internal static string LiveIndexZeroStreamListUrl => LiveApiUrlBase + "getindexzerostreamlist?status=";

        internal static string LiveWatchingReservationListUrl => LiveApiUrlBase + "watchingreservation?mode=list";

        internal static string LiveWatchingReservationDetailListUrl => LiveApiUrlBase + "watchingreservation?mode=detaillist";

        #endregion

        #region Images

        private const string ImageUrlBase = "http://seiga" + DomainBase;
        private const string ImageApiUrlBase = ImageUrlBase + "api/";
        private const string ImageExtApiUrlBase = "http://ext.seiga" + DomainBase + "api/";

        /// <summary>
        ///     ニコニコ静画 トップ ページ URL テキスト
        /// </summary>
        public static string ImageTopPageUrl => ImageUrlBase;

        /// <summary>
        ///     ニコニコ静画 マイ ページ URL テキスト
        /// </summary>
        public static string ImageMyPageUrl => ImageUrlBase + "my";

        /// <summary>
        ///     ニコニコ静画 お題 トップ ページ URL テキスト
        /// </summary>
        public static string ImageThemeTopPageUrl => ImageUrlBase + "theme/";

        /// <summary>
        ///     ニコニコ静画 イラスト トップ ページ URL テキスト
        /// </summary>
        public static string ImageIllustTopPageUrl => ImageUrlBase + "illust/";

        /// <summary>
        ///     ニコニコ春画 トップ ページ URL テキスト
        /// </summary>
        public static string ImageIllustAdultTopPageUrl => ImageUrlBase + "shunga/";

        /// <summary>
        ///     ニコニコ静画 漫画 トップ ページ URL テキスト
        /// </summary>
        public static string ImageMangaTopPageUrl => ImageUrlBase + "manga/";

        /// <summary>
        ///     ニコニコ静画 電子書籍 トップ ページ URL テキスト
        /// </summary>
        public static string ImageElectronicBookTopPageUrl => ImageUrlBase + "book/";

        internal static string ImageBlogPartsUrl => ImageExtApiUrlBase + "illust/blogparts?mode=";

        internal static string ImageUserInfoUrl => ImageApiUrlBase + "user/info?id=";

        internal static string ImageUserDataUrl => ImageApiUrlBase + "user/data?id=";

        #endregion

        #region Searches

        private const string SearchApiUrlBase = "http://api.search" + DomainBase + "api/";

        internal static string SearchSuggestionUrl => "http://search" + DomainBase + "suggestion/complete/";

        #endregion

        #region Dictionaries

        private const string DictionaryUrlBase = "http://dic" + DomainBase;
        private const string DictionaryApiUrlBase = "http://api.nicodic.jp/";

        /// <summary>
        ///     ニコニコ大百科 トップ ページ URL テキスト
        /// </summary>
        public static string DictionaryTopPageUrl => DictionaryUrlBase;

        internal static string DictionaryWordExistUrl => DictionaryApiUrlBase + "e/json/";

        internal static string DictionarySummarytUrl => DictionaryApiUrlBase + "page.summary/json/a/";

        internal static string DictionaryExistUrl => DictionaryApiUrlBase + "page.exist/json/";

        internal static string DictionaryRecentUrl => DictionaryApiUrlBase + "page.created/json";

        #endregion

        #region Apps

        private const string AppUrlBase = "http://app" + DomainBase;

        /// <summary>
        ///     ニコニコアプリ トップ ページ URL テキスト
        /// </summary>
        public static string AppTopPageUrl => AppUrlBase;

        /// <summary>
        ///     ニコニコアプリ マイ ページ URL テキスト
        /// </summary>
        public static string AppMyPageUrl => AppUrlBase + "my/apps";

        #endregion

        #region Communities

        /// <summary>
        ///     ニコニコ コミュニティー アイコン URL テキスト
        ///     {0}: CommunityID / 10000
        ///     {1}: CommunityID
        /// </summary>
        public static string CommunityIconUrl => "http://icon.nimg.jp/community/{0}/co{1}.jpg";

        /// <summary>
        ///     ニコニコ コミュニティー 小アイコン URL テキスト
        ///     {0}: CommunityID / 10000
        ///     {1}: CommunityID
        /// </summary>
        public static string CommunitySmallIconUrl => "http://icon.nimg.jp/community/s/{0}/co{1}.jpg";

        /// <summary>
        ///     ニコニコ コミュニティー アイコン未設定 URL テキスト
        /// </summary>
        public static string CommunityBlankIconUrl => "http://icon.nimg.jp/404.jpg";

        #endregion

        #region Channels

        /// <summary>
        ///     ニコニコ チャンネル アイコン URL テキスト
        ///     {0}: ChannelID
        /// </summary>
        public static string ChannelIconUrl => "http://icon.nimg.jp/channel/ch{0}.jpg";

        /// <summary>
        ///     ニコニコ チャンネル 小アイコン URL テキスト
        ///     {0}: ChannelID
        /// </summary>
        public static string ChannelSmallIconUrl => "http://icon.nimg.jp/channel/s/ch{0}.jpg";

        #endregion

        #region Users

        /// <summary>
        ///     ニコニコ ユーザー ページ URL テキスト
        /// </summary>
        public static string UserPageUrl => VideoUrlBase + "my";

        /// <summary>
        ///     ニコニコ ユーザー アイコン URL テキスト
        ///     {0}: UserID / 10000
        ///     {1}: UserID
        /// </summary>
        public static string UserIconUrl => "http://usericon.nimg.jp/usericon/{0}/{1}.jpg";

        /// <summary>
        ///     ニコニコ ユーザー 小アイコン URL テキスト
        ///     {0}: UserID / 10000
        ///     {1}: UserID
        /// </summary>
        public static string UserSmallIconUrl => "http://usericon.nimg.jp/usericon/s/{0}/{1}.jpg";

        /// <summary>
        ///     ニコニコ ユーザー アイコン未設定 URL テキスト
        /// </summary>
        public static string UserBlankIconUrl => "http://uni.res.nimg.jp/img/user/thumb/blank.jpg";

        #endregion
    }
}