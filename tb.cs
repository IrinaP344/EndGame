﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tb : MonoBehaviour
{
	Slider slide;
    // Start is called before the first frame update
    void Start()
    {
        slide = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void changeValue(int arg)
    {
    	slide.value = arg;
    }
}
