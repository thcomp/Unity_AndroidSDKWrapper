using System;
using UnityEngine;

namespace android.graphics
{
    public class Rect
    {
        private AndroidJavaObject mAndroidJO;

        public AndroidJavaObject AndroidJO
        {
            get
            {
                return mAndroidJO;
            }
        }

        public int Left
        {
            get
            {
                return mAndroidJO.Get<int>("left");
            }
            set
            {
                mAndroidJO.Set<int>("left", value);
            }
        }

        public int Top
        {
            get
            {
                return mAndroidJO.Get<int>("top");
            }
            set
            {
                mAndroidJO.Set<int>("top", value);
            }
        }

        public int Right
        {
            get
            {
                return mAndroidJO.Get<int>("right");
            }
            set
            {
                mAndroidJO.Set<int>("right", value);
            }
        }

        public Rect()
        {
            mAndroidJO = new AndroidJavaObject("android.graphics.Rect");
        }

        public Rect(int left, int top, int right, int bottom) : this()
        {
            Set(left, top, right, bottom);
        }

        public Rect(Rect rect) : this(rect.Left, rect.Top, rect.Right, rect.Bottom)
        {
        }

        public int Bottom
        {
            get
            {
                return mAndroidJO.Get<int>("bottom");
            }
            set
            {
                mAndroidJO.Set<int>("bottom", value);
            }
        }

        public int CenterX()
        {
            return mAndroidJO.Call<int>("centerX");
        }

        public int CenterY()
        {
            return mAndroidJO.Call<int>("centerY");
        }

        public Boolean Contains(int left, int top, int right, int bottom)
        {
            return mAndroidJO.Call<Boolean>("contains", left, top, right, bottom);
        }

        public Boolean Contains(Rect rect)
        {
            return mAndroidJO.Call<Boolean>("contains", rect.AndroidJO);
        }

        public Boolean Contains(int x, int y)
        {
            return mAndroidJO.Call<Boolean>("contains", x, y);
        }

        public float ExactCenterX()
        {
            return mAndroidJO.Call<float>("exactCenterX");
        }

        public float ExactCenterY()
        {
            return mAndroidJO.Call<float>("exactCenterY");
        }

        public int Height()
        {
            return mAndroidJO.Call<int>("height");
        }

        public int Inset(int dx, int dy)
        {
            return mAndroidJO.Call<int>("inset", dx, dy);
        }

        public Boolean Intersect(int left, int top, int right, int bottom)
        {
            return mAndroidJO.Call<Boolean>("intersect", left, top, right, bottom);
        }

        public Boolean Intersect(Rect rect)
        {
            return mAndroidJO.Call<Boolean>("intersect", rect.AndroidJO);
        }

        public Boolean Intersects(int left, int top, int right, int bottom)
        {
            return mAndroidJO.Call<Boolean>("intersects", left, top, right, bottom);
        }

        public Boolean Intersects(Rect aRect, Rect bRect)
        {
            return mAndroidJO.Call<Boolean>("intersects", aRect.AndroidJO, bRect.AndroidJO);
        }

        public Boolean IsEmpty()
        {
            return mAndroidJO.Call<Boolean>("isEmpty");
        }

        public void Offset(int dx, int dy)
        {
            mAndroidJO.Call("offset", dx, dy);
        }

        public void OffsetTo(int newLeft, int newTop)
        {
            mAndroidJO.Call("offsetTo", newLeft, newTop);
        }

        public void Set(int left, int top, int right, int bottom)
        {
            mAndroidJO.Call("set", left, top, right, bottom);
        }

        public void Set(Rect src)
        {
            mAndroidJO.Call("set", src.AndroidJO);
        }

        public void SetEmpty()
        {
            mAndroidJO.Call("setEmpty");
        }

        public void SetIntersect(Rect aRect, Rect bRect)
        {
            mAndroidJO.Call("setIntersect", aRect, bRect);
        }

        public void Sort()
        {
            mAndroidJO.Call("sort");
        }

        public String toShortString()
        {
            return mAndroidJO.Call<String>("toShortString");
        }

        public void Union(int left, int top, int right, int bottom)
        {
            mAndroidJO.Call("union", left, top, right, bottom);
        }

        public void Union(Rect rect)
        {
            mAndroidJO.Call("union", rect.AndroidJO);
        }

        public void Union(int x, int y)
        {
            mAndroidJO.Call("union", x, y);
        }

        public int Width()
        {
            return mAndroidJO.Call<int>("width");
        }
    }
}
