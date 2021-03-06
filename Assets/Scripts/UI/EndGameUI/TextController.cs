﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TextController : MonoBehaviour
{
    public Text text;

    virtual public void Awake() { }
    virtual public void SetText() { }
}
