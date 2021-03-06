﻿#if WINDOWS_APP
using System;
using Windows.Foundation;
#else
using System.Threading.Tasks;
#endif

namespace Mntone.Nico2.Images.Users
{
	/// <summary>
	/// ニコニコ静画のユーザー API 群
	/// </summary>
	public sealed class UserApi
	{
		internal UserApi( NiconicoContext context )
		{
			this._context = context;
		}

		/// <summary>
		/// [非ログオン可] 非同期操作として user/info を取得します
		/// </summary>
		/// <param name="requestUserId">目的のユーザー ID</param>
		/// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<Info.InfoResponse> GetInfoAsync( uint requestUserId )
		{
			return Info.InfoClient.GetInfoAsync( this._context, requestUserId ).AsAsyncOperation();
		}
#else
		public Task<Info.InfoResponse> GetInfoAsync( uint requestUserId )
		{
			return Info.InfoClient.GetInfoAsync( this._context, requestUserId );
		}
#endif

		/// <summary>
		/// 非同期操作として user/data を取得します
		/// </summary>
		/// <param name="requestUserId">目的のユーザー ID</param>
		/// <returns>非同期操作を表すオブジェクト</returns>
#if WINDOWS_APP
		public IAsyncOperation<Data.DataResponse> GetDataAsync( uint requestUserId )
		{
			return Data.DataClient.GetDataAsync( this._context, requestUserId ).AsAsyncOperation();
		}
#else
		public Task<Data.DataResponse> GetDataAsync( uint requestUserId )
		{
			return Data.DataClient.GetDataAsync( this._context, requestUserId );
		}
#endif


		#region field

		private NiconicoContext _context;

		#endregion
	}
}