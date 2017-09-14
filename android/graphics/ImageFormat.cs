using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace android.graphics
{
    public class ImageFormat
    {
        public static readonly int DEPTH16 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("DEPTH16");
        public static readonly int DEPTH_POINT_CLOUD = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("DEPTH_POINT_CLOUD");
        public static readonly int FLEX_RGBA_8888 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("FLEX_RGBA_8888");
        public static readonly int FLEX_RGB_888 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("FLEX_RGB_888");
        public static readonly int JPEG = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("JPEG");
        public static readonly int NV16 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("NV16");
        public static readonly int NV21 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("NV21");
        public static readonly int PRIVATE = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("PRIVATE");
        public static readonly int RAW10 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("RAW10");
        public static readonly int RAW12 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("RAW12");
        public static readonly int RAW_PRIVATE = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("RAW_PRIVATE");
        public static readonly int RAW_SENSOR = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("RAW_SENSOR");
        public static readonly int RGB_565 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("RGB_565");
        public static readonly int UNKNOWN = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("UNKNOWN");
        public static readonly int YUV_420_888 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("YUV_420_888");
        public static readonly int YUV_422_888 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("YUV_422_888");
        public static readonly int YUV_444_888 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("YUV_444_888");
        public static readonly int YUY2 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("YUY2");
        public static readonly int YV12 = new AndroidJavaClass("android.graphics.ImageFormat").GetStatic<int>("YV12");
    }
}
