using System;
using UnityEngine;

namespace android.graphics
{
    public class BitmapFactory
    {
        public static Bitmap decodeByteArray(byte[] data, int offset, int length, BitmapFactory.Options opts)
        {
            AndroidJavaClass bitmapFactory = new AndroidJavaClass("android.graphics.BitmapFactory");
            AndroidJavaObject bitmapJO = bitmapFactory.CallStatic<AndroidJavaObject>("decodeByteArray", data, offset, length, opts != null ? opts.AndroidJO : null);

            Debug.Log("bitmapJO = " + bitmapJO);

            return new Bitmap(bitmapJO);
        }

        public class Options
        {
            private AndroidJavaObject mAndroidJO;

            public Options()
            {
                mAndroidJO = new AndroidJavaObject("android.graphics.BitmapFactory$Options");
            }

            public AndroidJavaObject AndroidJO
            {
                get
                {
                    return mAndroidJO;
                }
            }

            public Bitmap InBitmap
            {
                get
                {
                    AndroidJavaObject inBitmapJO = mAndroidJO.Get<AndroidJavaObject>("inBitmap");
                    return new Bitmap(inBitmapJO);
                }
                set
                {
                    mAndroidJO.Set<AndroidJavaObject>("inBitmap", value.AndroidJO);
                }
            }

            public int InDensity
            {
                get
                {
                    return mAndroidJO.Get<int>("inDensity");
                }
                set
                {
                    mAndroidJO.Set<int>("inDensity", value);
                }
            }

            public Boolean InDither
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inDither");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inDither", value);
                }
            }

            public Boolean InInputShareable
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inInputShareable");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inInputShareable", value);
                }
            }

            public Boolean InJustDecodeBounds
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inJustDecodeBounds");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inJustDecodeBounds", value);
                }
            }

            public Boolean InMutable
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inMutable");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inMutable", value);
                }
            }

            public Boolean InPreferQualityOverSpeed
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inPreferQualityOverSpeed");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inPreferQualityOverSpeed", value);
                }
            }

            //public ColorSpace InPreferredColorSpace
            //{
            //    get
            //    {
            //        AndroidJavaObject outColorSpace = mAndroidJO.Get<AndroidJavaObject>("inPreferredColorSpace");
            //        return new ColorSpace(outColorSpace);
            //    }
            //    set
            //    {
            //        mAndroidJO.Set<AndroidJavaObject>("inPreferredColorSpace", value.AndroidJO);
            //    }
            //}

            public Bitmap.Config InPreferredConfig
            {
                get
                {
                    AndroidJavaObject inPreferredConfig = mAndroidJO.Get<AndroidJavaObject>("inPreferredConfig");
                    return new Bitmap.Config(inPreferredConfig);
                }
                set
                {
                    mAndroidJO.Set<AndroidJavaObject>("inPreferredConfig", value.AndroidJO);
                }
            }

            public Boolean InPremultiplied
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inPremultiplied");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inPremultiplied", value);
                }
            }

            public Boolean InPurgeable
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inPurgeable");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inPurgeable", value);
                }
            }

            public int InSampleSize
            {
                get
                {
                    return mAndroidJO.Get<int>("inSampleSize");
                }
                set
                {
                    mAndroidJO.Set<int>("inSampleSize", value);
                }
            }

            public Boolean InScaled
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("inScaled");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("inScaled", value);
                }
            }

            public int InScreenDensity
            {
                get
                {
                    return mAndroidJO.Get<int>("inScreenDensity");
                }
                set
                {
                    mAndroidJO.Set<int>("inScreenDensity", value);
                }
            }

            public int InTargetDensity
            {
                get
                {
                    return mAndroidJO.Get<int>("inTargetDensity");
                }
                set
                {
                    mAndroidJO.Set<int>("inTargetDensity", value);
                }
            }

            public byte[] InTempStorage
            {
                get
                {
                    return mAndroidJO.Get<byte[]>("inTempStorage");
                }
                set
                {
                    mAndroidJO.Set<byte[]>("inTempStorage", value);
                }
            }

            public Boolean mCancel
            {
                get
                {
                    return mAndroidJO.Get<Boolean>("mCancel");
                }
                set
                {
                    mAndroidJO.Set<Boolean>("mCancel", value);
                }
            }

            //public ColorSpace OutColorSpace
            //{
            //    get
            //    {
            //        AndroidJavaObject outColorSpace = mAndroidJO.Get<AndroidJavaObject>("outColorSpace");
            //        return new ColorSpace(outColorSpace);
            //    }
            //    set
            //    {
            //        mAndroidJO.Set<AndroidJavaObject>("outColorSpace", value.AndroidJO);
            //    }
            //}

            public Bitmap.Config OutConfig
            {
                get
                {
                    AndroidJavaObject outConfig = mAndroidJO.Get<AndroidJavaObject>("outConfig");
                    return new Bitmap.Config(outConfig);
                }
                set
                {
                    mAndroidJO.Set<AndroidJavaObject>("outConfig", value.AndroidJO);
                }
            }

            public int OutHeight
            {
                get
                {
                    return mAndroidJO.Get<int>("outHeight");
                }
                set
                {
                    mAndroidJO.Set<int>("outHeight", value);
                }
            }

            public String OutMimeType
            {
                get
                {
                    return mAndroidJO.Get<String>("outMimeType");
                }
                set
                {
                    mAndroidJO.Set<String>("outMimeType", value);
                }
            }

            public int OutWidth
            {
                get
                {
                    return mAndroidJO.Get<int>("outWidth");
                }
                set
                {
                    mAndroidJO.Set<int>("outWidth", value);
                }
            }
        }
    }
}
