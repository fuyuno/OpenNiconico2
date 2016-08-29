using Mntone.Nico2.Users.Icon;
using Mntone.Nico2.Users.Info;
#if WINDOWS_APP
using System;
using Windows.Foundation;
using Windows.Storage.Streams;
#else
using System.Threading.Tasks;

#endif

namespace Mntone.Nico2.Users
{
    /// <summary>
    ///     ニコニコ ユーザー API 群
    /// </summary>
    public sealed class UserApi
    {
        #region field

        private readonly NiconicoContext _context;

        #endregion

        internal UserApi(NiconicoContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     [非ログオン可] 非同期操作としてユーザー アイコンを取得します
        /// </summary>
        /// <param name="requestUserId">目的のユーザー ID</param>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<IBuffer> GetIconAsync( uint requestUserId )
		{
			return Icon.IconClient.GetIconAsync( this._context, requestUserId ).AsAsyncOperation();
		}
#else
        public Task<byte[]> GetIconAsync(uint requestUserId)
        {
            return IconClient.GetIconAsync(_context, requestUserId);
        }
#endif

        public string GetIconUrl(uint requestUserId)
            => IconClient.GetIconUrl(requestUserId);

        /// <summary>
        ///     非同期操作としてユーザー情報を取得します
        /// </summary>
        /// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<Info.InfoResponse> GetInfoAsync()
		{
			return Info.InfoClient.GetInfoAsync( this._context ).AsAsyncOperation();
		}
#else
        public Task<InfoResponse> GetInfoAsync()
        {
            return InfoClient.GetInfoAsync(_context);
        }
#endif
    }
}