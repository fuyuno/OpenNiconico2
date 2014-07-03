﻿using System;
using System.Threading.Tasks;

#if WINDOWS_APP
using Windows.Data.Xml.Dom;
#else
using System.Xml.Linq;
#endif

namespace Mntone.Nico2.Images.Users.Data
{
	internal sealed class DataClient
	{
		public static Task<string> GetDataDataAsync( NiconicoContext context, uint requestUserID )
		{
			return context.GetClient().GetString2Async( NiconicoUrls.ImageUserDataUrl + requestUserID );
		}

		public static DataResponse ParseDataData( string dataData )
		{
#if WINDOWS_APP
			var xml = new XmlDocument();
			xml.LoadXml( dataData, new XmlLoadSettings { ElementContentWhiteSpace = false, MaxElementDepth = 4 } );
#else
			var xml = XDocument.Parse( dataData, LoadOptions.None );
#endif

			var responseXml = xml.GetDocumentRootNode();
			if( responseXml.GetName() != "response" )
			{
				throw new Exception( "Parse Error: Node name is invalid." );
			}

			return new DataResponse( responseXml );
		}

		public static Task<DataResponse> GetDataAsync( NiconicoContext context, uint requestUserID )
		{
			return GetDataDataAsync( context, requestUserID )
				.ContinueWith( prevTask => ParseDataData( prevTask.Result ) );
		}
	}
}