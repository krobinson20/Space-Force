using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class FuelBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxFuel(float fuel)
    {
        slider.maxValue = fuel;
        slider.value = fuel;
    }

    public void SetFuel(float fuel)
    {
        slider.value = fuel;
    }

}
