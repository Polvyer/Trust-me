using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPadOpenDoor : MonoBehaviour
{
    int i = 0;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Destroy(GetComponent<HingeJoint>()); // First destroy hingeJoint in order to correctly freeze the door in place
        // door should only open when the correct pin is inputted
    }

    private void OnTriggerEnter(Collider other)
    {
        HingeJoint hc = gameObject.AddComponent<HingeJoint>() as HingeJoint; // Readd the hinge joint to open door
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        if (other.gameObject.name == "First Person Player" && GameObject.Find("keypadCanvas").GetComponent<toggleKeypad>().unlockDoor)
        {
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

}
