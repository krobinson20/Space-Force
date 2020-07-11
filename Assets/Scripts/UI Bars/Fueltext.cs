using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fueltext : MonoBehaviour
{
    public Text text;
    private float currentFuel;
    public float CurrentFuel
    {
        get
        {
            return currentFuel;
        }
        set
        {
            currentFuel = value;
        }
    }

    private void Awake()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }
    public void SetMaxFuel(float fuel)
    {
        text.text = (fuel).ToString("0") + "%";
        currentFuel = fuel;
    }

    public void SetFuel(float fuel)
    {
        currentFuel = fuel;
        text.text = (currentFuel).ToString("0") + "%";

    }
}

