﻿using Mntone.Nico2.Live;
using Mntone.Nico2.Vita;
using Mntone.Nico2.Vita.Live.OnAirPrograms;
using Newtonsoft.Json.Linq;
using System;

#if WINDOWS_APP
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace Mntone.Nico2.Test.Vita.Live
{
	[TestClass]
	public sealed class OnAirProgramsUnitTest
	{
		private void CheckMethod( string data )
		{
			var actual = OnAirProgramsClient.ParseOnAirProgramsData( data );
			var expected = JObject.Parse( data )["nicolive_video_response"];

			var expectedProgramsInfo = expected["video_info"].AsJEnumerable();
			for( var i = 0; i < actual.Programs.Count; ++i )
			{
				var actualProgramInfo = actual.Programs[i];
				var expectedProgramInfo = expectedProgramsInfo[i];

				LiveAssert.CheckSimpleVideo( expectedProgramInfo["video"], actualProgramInfo.Video );
				LiveAssert.CheckSimpleCommunity( expectedProgramInfo["community"], actualProgramInfo.Community );
				Assert.IsNull( actualProgramInfo.Tags );
			}

			Assert.AreEqual( expected["count"].Value<ushort>(), actual.ParticalCount );
			Assert.AreEqual( expected["total_count"].Value<ushort>(), actual.TotalCount );
		}

		[TestMethod]
		public void OnAirPrograms_0不正なRange()
		{
			Assert2.ThrowsException<ArgumentOutOfRangeException>( () =>
			{
				OnAirProgramsClient.GetOnAirProgramsAsync( new NiconicoVitaContext(), CommunityType.Official, SortDirection.Ascending, SortType.StartTime, Range.FromFor( 0, 150 ) ).GetAwaiter().GetResult();
			} );
		}

		[TestMethod]
		public void OnAirPrograms_1officialデータ()
		{
			var data = TestHelper.Load( @"Vita/Live/OnAirPrograms/official.json" );
			CheckMethod( data );
		}

		[TestMethod]
		public void OnAirPrograms_2channelデータ()
		{
			var data = TestHelper.Load( @"Vita/Live/OnAirPrograms/channel.json" );
			CheckMethod( data );
		}

		[TestMethod]
		public void OnAirPrograms_3communityデータ()
		{
			var data = TestHelper.Load( @"Vita/Live/OnAirPrograms/community.json" );
			CheckMethod( data );
		}
	}
}