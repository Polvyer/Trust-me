using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public AudioClip sound;
    bool on;

    void Start()
    {
        //start with light off
        this.GetComponent<Light>().enabled = false;
        on = false;

        //set up sound effect
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
    }

    void Update()
    {
        //pressing L toggles light on/off
        if (Input.GetKey(KeyCode.L))
        {
            if (on)
            {   //if light is on, turn it off
                this.GetComponent<Light>().enabled = false;
                on = false;
            }
            else
            {   //if light is off, turn on
                this.GetComponent<Light>().enabled = true;
                on = true;
            }
            //play light switch sound
            GetComponent<AudioSource>().Play();
        }
    }
}
