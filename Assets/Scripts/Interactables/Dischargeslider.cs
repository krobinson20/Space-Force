using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dischargeslider : MonoBehaviour
{
    [SerializeField]
    public Text TextField;

    private Ship ship;
    private Powertext powertext;

    void Start()
    {
        ship = GetComponent<Ship>();
        powertext = GameObject.Find("Ship").GetComponent<Powertext>();
    }

    public void SetText(float sliderval)
    {
        powertext.CurrentPower = Mathf.Round(sliderval * 100);
        powertext.SetPower(powertext.CurrentPower);
    }
}