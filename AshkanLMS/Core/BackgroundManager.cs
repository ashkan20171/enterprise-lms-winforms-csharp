using System;
using System.Drawing;
using System.IO;

namespace AshkanLMS.Core
{
    public static class BackgroundManager
    {
        public static string CurrentPath
        {
            get
            {
                var file = AppSession.Persian ? "background-fa.jpg" : "background-en.jpg";
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", file);
            }
        }

        public static Image LoadCurrent()
        {
            try
            {
                var path = CurrentPath;
                if (!File.Exists(path)) return null;
                using (var source = Image.FromFile(path))
                    return new Bitmap(source);
            }
            catch { return null; }
        }
    }
}
