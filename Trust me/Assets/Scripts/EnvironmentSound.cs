using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSound : MonoBehaviour
{
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider player)
    {
        GetComponent<AudioSource>().Stop();
    }
}
