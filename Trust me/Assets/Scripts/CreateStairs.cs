using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStairs : MonoBehaviour
{
    static int counter = 0;
    public int maxStairs;

    // Start is called before the first frame update
    void Start()
    {
        counter++;
        if (counter < maxStairs)
        {
            DoTheStairs();
        }
    }

    private void DoTheStairs()
    {
        var myPos = transform.position;
        var go = Instantiate(gameObject, new Vector3(myPos.x, myPos.y + 0.17f, myPos.z - 0.46f), Quaternion.identity) as GameObject;
        go.name = "Stair (" + counter + ")";
    }
}
