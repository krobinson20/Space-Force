using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powertext : MonoBehaviour
{
    public Text text;
    private float currentPower;
    public float CurrentPower
    {
        get
        {
            return currentPower;
        }
        set
        {
            currentPower = value;
        }
    }

    private void Awake()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }
    public void SetMaxPower(float power)
    {
        text.text = (power).ToString("0") + "%";
        currentPower = power;

    }

    public void SetPower(float power)
    {
        currentPower = power;
        text.text = (currentPower).ToString("0") + "%";

    }
}

