using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Mntone.Nico2.Live.Bookmark
{
    internal sealed class BookmarkClient
    {
        public static async Task<BookmarkResponse> GetBookmarksAsync(NiconicoContext context, int page = 1)
        {
            var response = await context.GetClient().GetStringAsync(string.Format(NiconicoUrls.LiveBookmarksUrl, page));
            var serializer = new DataContractJsonSerializer(typeof(BookmarkResponse));
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(response)))
            {
                return (BookmarkResponse) serializer.ReadObject(stream);
            }
        }
    }
}