using System.Collections;
using System.Collections.Generic;

//using static Ship;
using UnityEngine;
//using UnityEngine.UI;

public class PitchUp : MonoBehaviour
{
    private Ship ship;
    private FuelBar fBar;
    private PowerBank pBank;
    //private Slider slider;
    void Awake()
    {
        ship = GetComponent<Ship>();
        pBank = GetComponent<PowerBank>();
        fBar = GetComponent<FuelBar>();
    }

    public float PitchUp1()
    {
        return fBar.slider.value -= 10f;
    }
    public float PitchUp2()
    {
        return pBank.slider.value -= 10f;
    }

    public void ApplyValues()
    {
        fBar.SetFuel(PitchUp1());
        pBank.SetPower(PitchUp2());
    }
}
