using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class FuelBar : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
    //public Image fill; //who is phill?

    public void SetMaxFuel(float fuel)
    {
        //fill.color = gradient.Evaluate(1f);
        slider.maxValue = fuel;
        slider.value = fuel;
    }

    public void SetFuel(float fuel)
    {
        //fill.color = gradient.Evaluate(slider.normalizedValue);
        slider.value = fuel;
    }

}
