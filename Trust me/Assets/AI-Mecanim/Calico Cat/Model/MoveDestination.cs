// MoveDestination.cs from https://docs.unity3d.com/Manual/nav-MoveToDestination.html
using UnityEngine;
using UnityEngine.AI;

public class MoveDestination : MonoBehaviour
{

    public Transform goal;
    // private NavMeshAgent agent;
    
    void Start()
    {
        GameObject go = new GameObject("Target");
        Vector3 sourcePostion = new Vector3(100, 20, 100);//The position you want to place your agent
        NavMeshHit closestHit;
        if (NavMesh.SamplePosition(sourcePostion, out closestHit, 500, 1))
        {
            go.transform.position = closestHit.position;
            go.AddComponent<NavMeshAgent>();
            //TODO
        }
        else
        {
            Debug.Log("ERROR");
        }

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}