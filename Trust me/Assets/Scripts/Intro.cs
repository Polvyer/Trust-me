using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public AudioClip sound;
    public GameObject player;
    private bool playedAlready = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && !playedAlready)
        {
            playedAlready = true;
            GetComponent<AudioSource>().Play();
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(37);
        player.GetComponent<PlayerMovement>().frozen = false;
    }
}
