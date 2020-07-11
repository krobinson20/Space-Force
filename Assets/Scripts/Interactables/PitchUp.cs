using System.Collections;
using System.Collections.Generic;
using static Ship;
using UnityEngine;

public class PitchUp : MonoBehaviour
{
    private Ship ship;
    void Awake()
    {
        ship = GetComponent<Ship>();
    }

    public float PitchUp1()
    {
        return ship.FuelBar.slider.value -= 10f;
    }
    public float PitchUp2()
    {
        return ship.PowerBank.slider.value -= 10f;
    }

    public void OnClick()
    {
        ship.FuelBar.SetFuel(PitchUp1());
        ship.PowerBank.SetPower(PitchUp2()); 
    }
}
