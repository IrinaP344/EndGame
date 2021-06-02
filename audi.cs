using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audi : MonoBehaviour
{
	AudioSource audio;
	MeshRenderer display;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        display = GetComponent<MeshRenderer>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
