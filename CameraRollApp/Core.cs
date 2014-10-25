using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace CameraRollApp
{
    public class Core
    {
        public static async Task<IReadOnlyList<StorageFile>> getImages()
        {
            var folder = await KnownFolders.CameraRoll.GetFilesAsync();
            return folder;
        }
    }
}
