using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PowerBank : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
    //public Image fill; //who is phill?

    public void SetMaxPower(float power)
    {
        //fill.color = gradient.Evaluate(1f);
        slider.maxValue = power;
        slider.value = power;
    }

    public void SetPower(float power)
    {
        //fill.color = gradient.Evaluate(slider.normalizedValue);
        slider.value = power;
    }

}