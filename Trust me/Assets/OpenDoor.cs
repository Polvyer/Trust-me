using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "First Person Player") {
            if (i % 2 == 0)
            {
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
