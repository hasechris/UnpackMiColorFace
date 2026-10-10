using System;
using System.IO;
using XiaomiWatch.Common;

namespace UnpackMiColorFace.Helpers
{
    internal class FilenameHelper
    {
        private string filename;

        public FilenameHelper(string filename)
        {
            this.filename = filename;
        }

        public string NameNoExt => Path.GetFileNameWithoutExtension(filename);

        public string GetFaceSlotImagesFolder(WatchType watchType, int slotId, int subversion) => watchType switch
        {
            WatchType.Gen3 => Path.Combine(NameNoExt, "images"),
            WatchType.MiWatchS3 => Path.Combine(NameNoExt, "images"),
            WatchType.MiBand9 => Path.Combine(NameNoExt, "images"),
            WatchType.MiBand8Pro => Path.Combine(NameNoExt, "images"),
            _ => slotId switch
            {
                0 => Path.Combine(NameNoExt, "images"),
                1 => Path.Combine(NameNoExt, "AOD", "images"),
                _ => Path.Combine(NameNoExt, $"images_{slotId}")
            }
        };

        internal string GetFaceSlotFilename(WatchType watchType, int slotId, int subversion)
        {
            string facefile = slotId > 0 ? $"{NameNoExt}_{slotId}" : NameNoExt;

            if (watchType == WatchType.Gen3
                || watchType == WatchType.MiWatchS3
                || watchType == WatchType.MiBand9
                || watchType == WatchType.MiBand8Pro)
            {
                if ((subversion & 0x04) > 0 && slotId == 1)
                    facefile = $"{NameNoExt}_AOD";
            }
            else
            {
                if (slotId == 1) facefile = Path.Combine("AOD", NameNoExt);
            }

            return facefile;
        }
    }
}