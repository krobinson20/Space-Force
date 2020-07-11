using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UP : MonoBehaviour
{
    [SerializeField]
    public Text TextField;

    private Ship ship;
    private Integritytext integritytext;
    void Awake()
    {
        ship = GetComponent<Ship>();
        integritytext = GameObject.Find("Ship").GetComponent<Integritytext>();
    }

    public void SetText()
    {
        //call the funciton that will handle the math and pass it back to here
        //that will edit the value for the numbers to change
        integritytext.CurrentIntegrity -= 1;
        integritytext.SetIntegrity(integritytext.CurrentIntegrity);        
    }


}
