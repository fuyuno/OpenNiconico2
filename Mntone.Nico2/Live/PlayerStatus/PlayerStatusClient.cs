﻿using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Web.Http;

namespace Mntone.Nico2.Live.PlayerStatus
{
	internal sealed class PlayerStatusClient
	{
		public static IAsyncOperationWithProgress<string, HttpProgress> GetPlayerStatusDataAsync( NiconicoContext context, string requestID )
		{
			if( !NiconicoRegex.IsLiveID( requestID ) )
			{
				throw new ArgumentException();
			}

			return context.GetClient().GetStringAsync( new Uri( NiconicoUrls.LivePlayerStatustUrl + requestID ) );
		}

		public static PlayerStatusResponse ParsePlayerStatusData( string playerStatusData )
		{
			var xml = new XmlDocument();
			xml.LoadXml( playerStatusData, new XmlLoadSettings { MaxElementDepth = 6 } );

			var getPlayerStatusXml = xml.ChildNodes[1];
			if( getPlayerStatusXml.NodeName != "getplayerstatus" )
			{
				throw new Exception( "Parse Error: Node name is invalid." );
			}

			return new PlayerStatusResponse( getPlayerStatusXml );
		}

		public static IAsyncOperation<PlayerStatusResponse> GetPlayerStatusAsync( NiconicoContext context, string requestID )
		{
			return GetPlayerStatusDataAsync( context, requestID )
				.AsTask()
				.ContinueWith( prevTask => ParsePlayerStatusData( prevTask.Result ) )
				.AsAsyncOperation();
		}
	}
}