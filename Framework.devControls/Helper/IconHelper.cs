using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Framework
{
    /// <summary>
    /// Message Icon Helper
    /// </summary>
    public static class IconHelper
    {
        #region Public Static Method

        /// <summary>
        /// Create Image Method
        /// </summary>
        /// <param name="icon">Icon Object</param>
        /// <returns>Icon Return</returns>
        public static ImageSource ToImageSource(this Icon icon)
        {
            Bitmap bitmap = icon.ToBitmap();
            IntPtr hBitmap = bitmap.GetHbitmap();

            ImageSource wpfBitmap = Imaging.CreateBitmapSourceFromHBitmap(
              hBitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            if (!DeleteObject(hBitmap))
            {
                throw new Win32Exception();
            }

            return wpfBitmap.GetAsFrozen() as ImageSource;
        }

        #endregion

        #region Private Method

        /// <summary>
        /// DeleteObject Method  
        /// </summary>
        /// <param name="hObject">Icon Object</param>
        /// <returns>Icon return</returns>
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);

        #endregion
    }
}
