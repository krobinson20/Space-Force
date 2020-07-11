using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class IntegrityBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill; //who is phill?

    public void SetMaxIntegrity(float integ)
    {
        fill.color = gradient.Evaluate(1f);
        slider.maxValue = integ;
        slider.value = integ;
    }

    public void SetIntegrity(float integ)
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);
        slider.value = integ;
    }

}