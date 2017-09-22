using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

abstract public class BaseAndroidJavaObjectWrapper
{
    internal AndroidJavaObject mAndroidJO;

    public BaseAndroidJavaObjectWrapper()
    {
    }

    public BaseAndroidJavaObjectWrapper(AndroidJavaObject androidJO)
    {
        mAndroidJO = androidJO;
    }

    internal AndroidJavaObject AndroidJO
    {
        get
        {
            return mAndroidJO;
        }
    }
}
