using System;
using UnityEngine;

namespace android.graphics
{
    public class Point : BaseAndroidJavaObjectWrapper
    {
        public int x
        {
            get
            {
                return mAndroidJO.Get<int>("x");
            }
            set
            {
                mAndroidJO.Set<int>("x", value);
            }
        }

        public int y
        {
            get
            {
                return mAndroidJO.Get<int>("y");
            }
            set
            {
                mAndroidJO.Set<int>("y", value);
            }
        }

        public Point(AndroidJavaObject androidJO) : base(androidJO)
        {
            // 処理なし
        }

        public Point(int xPos, int yPos)
        {
            mAndroidJO = new AndroidJavaObject("android.graphics.Point", xPos, yPos);
        }

        public Point(Point p)
        {
            mAndroidJO = new AndroidJavaObject("android.graphics.Point", p);
        }

        public Boolean Equals(int xPos, int yPos)
        {
            return mAndroidJO.Call<Boolean>("equals", xPos, yPos);
        }

        public void Negate()
        {
            mAndroidJO.Call("negate");
        }

        public void Offset(int dx, int dy)
        {
            mAndroidJO.Call("offset", dx, dy);
        }

        public void Set(Point p)
        {
            mAndroidJO.Call("set", p);
        }

        public void Set(int x, int y)
        {
            mAndroidJO.Call("set", x, y);
        }
    }
}
