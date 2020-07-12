using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Integritytext : MonoBehaviour
{
    public Text text;
    private float currentIntegrity;
    public float CurrentIntegrity
    {
        get
        {
            return currentIntegrity;
        }
        set
        {
            currentIntegrity = value;
        }
    }

    private void Awake()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }
    public void SetMaxIntegrity(float integrity)
    {
        text.text = (integrity).ToString("0") + "%";
        currentIntegrity = integrity;
    }

    public void SetIntegrity(float integrity)
    {
        currentIntegrity = integrity;
        text.text = (currentIntegrity).ToString("0") + "%";
        
    }

    }
