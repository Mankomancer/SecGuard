using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomWalking : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject waypointScript;
    Vector3 destination;
    int waypointNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirstDestination());
        
        
    }

    IEnumerator FirstDestination(){
        int randomNumber = UnityEngine.Random.Range(2,5);
        yield return new WaitForSeconds(randomNumber);

        waypointNumber = waypointScript.GetComponent<CrowdWaypoints>().GetRandomWaypoint();
        agent.ResetPath();
        agent.destination = waypointScript.GetComponent<CrowdWaypoints>().GetWaypointCoordinates(waypointNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
