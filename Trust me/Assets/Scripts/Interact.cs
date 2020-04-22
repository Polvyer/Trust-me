using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject uiObject;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
    }

    private void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.P))
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }

    private void OnTriggerExit(Collider player)
    {
        uiObject.SetActive(false);
    }
}
