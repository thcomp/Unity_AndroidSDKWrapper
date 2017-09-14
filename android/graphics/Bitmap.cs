using java.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace android.graphics
{
    public class Bitmap
    {
        private AndroidJavaObject mAndroidJO;

        public AndroidJavaObject AndroidJO
        {
            get
            {
                return mAndroidJO;
            }
        }

        public Bitmap(AndroidJavaObject bitmapJO)
        {
            mAndroidJO = bitmapJO;
        }

        public Boolean Compress(Bitmap.CompressFormat format, int quality, OutputStream stream)
        {
            return mAndroidJO.Call<Boolean>("compress", format.AndroidJO, quality, stream.AndroidJO);
        }

        public class Config
        {
            private AndroidJavaObject mAndroidJO;

            public AndroidJavaObject AndroidJO
            {
                get
                {
                    return mAndroidJO;
                }
            }

            internal Config(AndroidJavaObject androidJO)
            {
                mAndroidJO = androidJO;
            }

            public static Config ValueOf(String name)
            {
                return new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").CallStatic<AndroidJavaObject>("valueOf", name));
            }

            public static Config[] Values()
            {
                return new Config[] { ALPHA_8, ARGB_4444, ARGB_8888, HARDWARE, RGBA_F16, RGB_565 };
            }

            public static readonly Config ALPHA_8 = new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").GetStatic<AndroidJavaObject>("ALPHA_8"));
            public static readonly Config ARGB_4444 = new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").GetStatic<AndroidJavaObject>("ARGB_4444"));
            public static readonly Config ARGB_8888 = new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").GetStatic<AndroidJavaObject>("ARGB_8888"));
            public static readonly Config HARDWARE = new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").GetStatic<AndroidJavaObject>("HARDWARE"));
            public static readonly Config RGBA_F16 = new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").GetStatic<AndroidJavaObject>("RGBA_F16"));
            public static readonly Config RGB_565 = new Config(new AndroidJavaClass("android.graphics.Bitmap$Config").GetStatic<AndroidJavaObject>("RGB_565"));
        }

        public class CompressFormat
        {
            private AndroidJavaObject mAndroidJO;

            public AndroidJavaObject AndroidJO
            {
                get
                {
                    return mAndroidJO;
                }
            }

            internal CompressFormat(AndroidJavaObject androidJO)
            {
                mAndroidJO = androidJO;
            }

            public static CompressFormat ValueOf(String name)
            {
                return new CompressFormat(new AndroidJavaClass("android.graphics.Bitmap$CompressFormat").CallStatic<AndroidJavaObject>("valueOf", name));
            }

            public static CompressFormat[] Values()
            {
                return new CompressFormat[] { JPEG, PNG, WEBP };
            }

            public static readonly CompressFormat JPEG = new CompressFormat(new AndroidJavaClass("android.graphics.Bitmap$CompressFormat").GetStatic<AndroidJavaObject>("JPEG"));
            public static readonly CompressFormat PNG = new CompressFormat(new AndroidJavaClass("android.graphics.Bitmap$CompressFormat").GetStatic<AndroidJavaObject>("PNG"));
            public static readonly CompressFormat WEBP = new CompressFormat(new AndroidJavaClass("android.graphics.Bitmap$CompressFormat").GetStatic<AndroidJavaObject>("WEBP"));
        }
    }
}
