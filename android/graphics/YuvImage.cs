using java.io;
using System;
using UnityEngine;

namespace android.graphics
{
    public class YuvImage
    {
        private AndroidJavaObject mAndroidJO;

        public YuvImage(byte[] yuv, int format, int width, int height, int[] strides)
        {
            mAndroidJO = new AndroidJavaObject("android.graphics.YuvImage", yuv, format, width, height, strides);
        }

        public Boolean CompressToJpeg(Rect rectangle, int quality, OutputStream stream)
        {
            return mAndroidJO.Call<Boolean>("compressToJpeg", rectangle.AndroidJO, quality, stream.AndroidJO);
        }
    }
}
