﻿using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Stat {

    [SerializeField]
    public BarScript bar;

    [SerializeField]
    private float maxVal;
    [SerializeField]
    private float currentVal;

    public float CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {
            this.currentVal = Mathf.Clamp(value, 0, MaxVal);
            if (bar != null)
            {
                bar.Value = currentVal;
            }
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            this.maxVal = value;
            if (bar != null)
            {
                bar.MaxValue = maxVal;
            }
        }
    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrentVal = currentVal;
    }

}
