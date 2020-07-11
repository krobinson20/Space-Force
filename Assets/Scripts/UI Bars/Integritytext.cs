using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Integritytext : MonoBehaviour
{
    public Text text;
    private float CurrentIntegrity;
    public float currentintegrity
    {
        get
        {
            return CurrentIntegrity;
        }
        set
        {
            CurrentIntegrity = value;
        }
    }

    public void SetMaxIntegrity(float integrity)
    {
        text.text = (integrity).ToString("0"); 
    }

    public void SetIntegrity(float integrity)
    {
        currentintegrity = integrity;
        text.text = (currentintegrity).ToString("0");
        
    }
}
