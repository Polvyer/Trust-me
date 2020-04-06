using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    int i = 0;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "First Person Player") {
            if (i % 2 == 0)
            {
                GetComponent<AudioSource>().Play();
                transform.Rotate(0, -90, 0);
            }
            else
            {
                transform.Rotate(0, 90, 0);
            }
            i++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
