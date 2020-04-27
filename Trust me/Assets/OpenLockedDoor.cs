using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLockedDoor : MonoBehaviour
{
    
    //public GameObject door;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log(GameObject.Find("KeypadCanvas").GetComponent<Keypad>().unlockDoor);
        if(GameObject.Find("KeypadCanvas").GetComponent<Keypad>().unlockDoor){
            //destroy door and play sound effect
            //GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}