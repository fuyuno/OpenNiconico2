using System.Collections.Generic;

using Mntone.Nico2.Live.Bookmark;
using Mntone.Nico2.Live.CKey;
using Mntone.Nico2.Live.Description;
using Mntone.Nico2.Live.Heartbeat;
using Mntone.Nico2.Live.Leave;
using Mntone.Nico2.Live.MyPage;
using Mntone.Nico2.Live.OnAirStreams;
using Mntone.Nico2.Live.OtherStreams;
using Mntone.Nico2.Live.PlayerStatus;
using Mntone.Nico2.Live.PostKey;
using Mntone.Nico2.Live.Reservations;
using Mntone.Nico2.Live.ReservationsInDetail;
using Mntone.Nico2.Live.TagRevision;
using Mntone.Nico2.Live.Tags;
using Mntone.Nico2.Live.Vote;

#if WINDOWS_APP
using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
#else

using System.Threading.Tasks;

#endif

namespace Mntone.Nico2.Live
{
    /// <summary>
    ///     ニコニコ生放送 API 群
    /// </summary>
    public sealed class LiveApi
    {
        #region field

        private readonly NiconicoContext _context;

        #endregion

        internal LiveApi(NiconicoContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     非同期操作として CKey を取得します
        /// </summary>
        /// <param name="refererId">生放送リファラー ID</param>
        /// <param name="requestId">目的の動画 ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<string> GetCKeyAsync( string refererId, string requestId )
		{
			return CKey.CKeyClient.GetCKeyAsync( this._context, refererId, requestId ).AsAsyncOperation();
		}
#else

        public Task<string> GetCKeyAsync(string refererId, string requestId)
        {
            return CKeyClient.GetCKeyAsync(_context, refererId, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作として番組説明を取得します
        /// </summary>
        /// <param name="requestId">目的の生放送 ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<Description.DescriptionResponse> GetDescriptionAsync( string requestId )
		{
			return Description.DescriptionClient.GetDescriptionAsync( this._context, requestId ).AsAsyncOperation();
		}
#else

        public Task<DescriptionResponse> GetDescriptionAsync(string requestId)
        {
            return DescriptionClient.GetDescriptionAsync(_context, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作としてハートビートを行います
        /// </summary>
        /// <param name="requestId">目的の生放送 ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<Heartbeat.HeartbeatResponse> HeartbeatAsync( string requestId )
		{
			return Heartbeat.HeartbeatClient.HeartbeatAsync( this._context, requestId ).AsAsyncOperation();
		}
#else

        public Task<HeartbeatResponse> HeartbeatAsync(string requestId)
        {
            return HeartbeatClient.HeartbeatAsync(_context, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作としてプレイヤー情報を取得します
        /// </summary>
        /// <param name="requestId">目的の生放送 ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<PlayerStatus.PlayerStatusResponse> GetPlayerStatusAsync( string requestId )
		{
			return PlayerStatus.PlayerStatusClient.GetPlayerStatusAsync( this._context, requestId ).AsAsyncOperation();
		}
#else

        public Task<PlayerStatusResponse> GetPlayerStatusAsync(string requestId)
        {
            return PlayerStatusClient.GetPlayerStatusAsync(_context, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作として放送を退出する要求を行います
        /// </summary>
        /// <param name="requestId">目的の生放送 ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<bool> LeaveAsync( string requestId )
		{
			return Leave.LeaveClient.LeaveAsync( this._context, requestId ).AsAsyncOperation();
		}
#else

        public Task<bool> LeaveAsync(string requestId)
        {
            return LeaveClient.LeaveAsync(_context, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作として放送中の番組一覧を取得します
        /// </summary>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		[Overload( "GetOnAirStreamsIndexAsync" )]
		public IAsyncOperation<OnAirStreams.OnAirStreamsResponse> GetOnAirStreamsIndexAsync()
		{
			return OnAirStreams.OnAirStreamsClient.GetOnAirStreamsIndexAsync( this._context ).AsAsyncOperation();
		}
#else

        public Task<OnAirStreamsResponse> GetOnAirStreamsIndexAsync()
        {
            return OnAirStreamsClient.GetOnAirStreamsIndexAsync(_context);
        }

#endif

        /// <summary>
        ///     非同期操作として放送中の番組一覧を取得します
        /// </summary>
        /// <param name="pageIndex">目的のページ番号</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		[Overload( "GetOnAirStreamsIndexWithPageIndexAsync" )]
		public IAsyncOperation<OnAirStreams.OnAirStreamsResponse> GetOnAirStreamsIndexAsync( ushort pageIndex )
		{
			return OnAirStreams.OnAirStreamsClient.GetOnAirStreamsIndexAsync( this._context, pageIndex ).AsAsyncOperation();
		}
#else

        public Task<OnAirStreamsResponse> GetOnAirStreamsIndexAsync(ushort pageIndex)
        {
            return OnAirStreamsClient.GetOnAirStreamsIndexAsync(_context, pageIndex);
        }

#endif

        /// <summary>
        ///     非同期操作として放送中の番組一覧を取得します
        /// </summary>
        /// <param name="pageIndex">目的のページ番号</param>
        /// <param name="category">カテゴリー</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		[Overload( "GetOnAirStreamsRecentAsync" )]
		public IAsyncOperation<OnAirStreams.OnAirStreamsResponse> GetOnAirStreamsRecentAsync( ushort pageIndex, Category category )
		{
			return OnAirStreams.OnAirStreamsClient.GetOnAirStreamsRecentAsync( this._context, pageIndex, category ).AsAsyncOperation();
		}
#else

        public Task<OnAirStreamsResponse> GetOnAirStreamsRecentAsync(ushort pageIndex, Category category)
        {
            return OnAirStreamsClient.GetOnAirStreamsRecentAsync(_context, pageIndex, category);
        }

#endif

        /// <summary>
        ///     非同期操作として放送中の番組一覧を取得します
        /// </summary>
        /// <param name="pageIndex">目的のページ番号</param>
        /// <param name="category">カテゴリー</param>
        /// <param name="direction">ソートの方向</param>
        /// <param name="type">ソートの種類</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		[Overload( "GetOnAirStreamsRecentWithSortMethodAsync" )]
		public IAsyncOperation<OnAirStreams.OnAirStreamsResponse> GetOnAirStreamsRecentAsync(
			ushort pageIndex, Category category, SortDirection direction, SortType type )
		{
			return OnAirStreams.OnAirStreamsClient.GetOnAirStreamsRecentAsync( this._context, pageIndex, category, direction, type ).AsAsyncOperation();
		}
#else

        public Task<OnAirStreamsResponse> GetOnAirStreamsRecentAsync(
            ushort pageIndex, Category category, SortDirection direction, SortType type)
        {
            return OnAirStreamsClient.GetOnAirStreamsRecentAsync(_context, pageIndex, category, direction, type);
        }

#endif

        /// <summary>
        ///     [非ログオン可] 非同期操作として指定した状態の番組一覧を取得します
        /// </summary>
        /// <param name="status">目的の状態</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		[Overload( "GetOtherStreamsAsync" )]
		public IAsyncOperation<OtherStreams.OtherStreamsResponse> GetOtherStreamsAsync( StatusType status )
		{
			return OtherStreams.OtherStreamsClient.GetOtherStreamsAsync( this._context, status, 1 ).AsAsyncOperation();
		}
#else

        public Task<OtherStreamsResponse> GetOtherStreamsAsync(StatusType status)
        {
            return OtherStreamsClient.GetOtherStreamsAsync(_context, status, 1);
        }

#endif

        /// <summary>
        ///     [非ログオン可] 非同期操作として指定した状態の番組一覧を取得します
        /// </summary>
        /// <param name="status">目的の状態</param>
        /// <param name="pageIndex">目的のページ番号</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		[Overload( "GetOtherStreamsWithPageIndexAsync" )]
		public IAsyncOperation<OtherStreams.OtherStreamsResponse> GetOtherStreamsAsync( StatusType status, ushort pageIndex )
		{
			return OtherStreams.OtherStreamsClient.GetOtherStreamsAsync( this._context, status, pageIndex ).AsAsyncOperation();
		}
#else

        public Task<OtherStreamsResponse> GetOtherStreamsAsync(StatusType status, ushort pageIndex)
        {
            return OtherStreamsClient.GetOtherStreamsAsync(_context, status, pageIndex);
        }

#endif

        /// <summary>
        ///     非同期操作としてタイムシフト予約している一覧を取得します
        /// </summary>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<IReadOnlyList<string>> GetReservationsAsync()
		{
			return Reservations.ReservationsClient.GetReservationsAsync( this._context ).AsAsyncOperation();
		}
#else

        public Task<IReadOnlyList<string>> GetReservationsAsync()
        {
            return ReservationsClient.GetReservationsAsync(_context);
        }

#endif

        /// <summary>
        ///     非同期操作としてタイムシフト予約している一覧 (詳細) を取得します
        /// </summary>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<ReservationsInDetail.ReservationsInDetailResponse> GetReservationsInDetailAsync()
		{
			return ReservationsInDetail.ReservationsInDetailClient.GetReservationsInDetailAsync( this._context ).AsAsyncOperation();
		}
#else

        public Task<ReservationsInDetailResponse> GetReservationsInDetailAsync()
        {
            return ReservationsInDetailClient.GetReservationsInDetailAsync(_context);
        }

#endif

        /// <summary>
        ///     非同期操作としてタグ リビジョンを取得します
        /// </summary>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<ushort> GetTagRevisionAsync( string requestId )
		{
			return TagRevision.TagRevisionClient.GetTagRevisionAsync( this._context, requestId ).AsAsyncOperation();
		}
#else

        public Task<ushort> GetTagRevisionAsync(string requestId)
        {
            return TagRevisionClient.GetTagRevisionAsync(_context, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作としてタグの内容を取得します
        /// </summary>
        /// <param name="requestId">目的の生放送 ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<Tags.TagsResponse> GetTagsAsync( string requestId )
		{
			return Tags.TagsClient.GetTagsAsync( this._context, requestId ).AsAsyncOperation();
		}
#else

        public Task<TagsResponse> GetTagsAsync(string requestId)
        {
            return TagsClient.GetTagsAsync(_context, requestId);
        }

#endif

        /// <summary>
        ///     非同期操作としてマイ ページの内容を取得します
        /// </summary>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<MyPage.MyPageResponse> GetMyPageAsync()
		{
			return MyPage.MyPageClient.GetMyPageAsync( this._context ).AsAsyncOperation();
		}
#else

        public Task<MyPageResponse> GetMyPageAsync()
        {
            return MyPageClient.GetMyPageAsync(_context);
        }

#endif

        /// <summary>
        ///     非同期操作として投稿キーを取得します
        /// </summary>
        /// <param name="threadId">スレッド ID</param>
        /// <param name="blockNo">ブロック番号</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<string> GetPostKeyAsync( uint threadId, uint blockNo )
		{
			return PostKey.PostKeyClient.GetPostKeyAsync( this._context, threadId, blockNo ).AsAsyncOperation();
		}
#else

        public Task<string> GetPostKeyAsync(uint threadId, uint blockNo)
        {
            return PostKeyClient.GetPostKeyAsync(_context, threadId, blockNo);
        }

#endif

        /// <summary>
        ///     非同期操作としてアンケートを投票します
        /// </summary>
        /// <param name="requestId">目的の生放送 ID</param>
        /// <param name="choiceNumber">選択した番号 (0～8)</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<bool> VoteAsync( string requestId, ushort choiceNumber )
		{
			return Vote.VoteClient.VoteAsync( this._context, requestId, choiceNumber ).AsAsyncOperation();
		}
#else

        public Task<bool> VoteAsync(string requestId, ushort choiceNumber)
        {
            return VoteClient.VoteAsync(_context, requestId, choiceNumber);
        }

#endif

        public Task<BookmarkResponse> GetBookmarksAsync(int page = 1)
            => BookmarkClient.GetBookmarksAsync(_context, page);
    }
}