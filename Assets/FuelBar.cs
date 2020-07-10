﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class FuelBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxFuel(int fuel)
    {
        slider.maxValue = fuel;
        slider.value = fuel;
    }

    public void SetFuel(int fuel)
    {
        slider.value = fuel;
    }

}
