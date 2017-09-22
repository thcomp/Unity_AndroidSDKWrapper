using System;
using UnityEngine;

namespace android.graphics
{
    public class PointF : BaseAndroidJavaObjectWrapper
    {
        public float x
        {
            get
            {
                return mAndroidJO.Get<float>("x");
            }
            set
            {
                mAndroidJO.Set<float>("x", value);
            }
        }

        public float y
        {
            get
            {
                return mAndroidJO.Get<float>("y");
            }
            set
            {
                mAndroidJO.Set<float>("y", value);
            }
        }

        public PointF(AndroidJavaObject androidJO) : base(androidJO)
        {
            // 処理なし
        }

        public PointF(float xPos, float yPos)
        {
            mAndroidJO = new AndroidJavaObject("android.graphics.PointF", xPos, yPos);
        }

        public PointF(Point p)
        {
            mAndroidJO = new AndroidJavaObject("android.graphics.PointF", p);
        }

        public Boolean Equals(float xPos, float yPos)
        {
            return mAndroidJO.Call<Boolean>("equals", xPos, yPos);
        }

        public static float Length(float xPos, float yPos)
        {
            return new AndroidJavaClass("android.graphics.PointF").CallStatic<float>("length", xPos, yPos);
        }

        public float Length()
        {
            return mAndroidJO.Call<float>("length");
        }

        public void Negate()
        {
            mAndroidJO.Call("negate");
        }

        public void Offset(float dx, float dy)
        {
            mAndroidJO.Call("offset", dx, dy);
        }

        public void Set(PointF p)
        {
            mAndroidJO.Call("set", p);
        }

        public void Set(float x, float y)
        {
            mAndroidJO.Call("set", x, y);
        }
    }
}
