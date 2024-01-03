using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdWaypoints : MonoBehaviour
{
    
    [SerializeField] private GameObject [] waypoints; //stores location where NPC are allowed to be
    private bool [] waypoint_allowed = new bool[9434];
    // Start is called before the first frame update
    void Start(){
        for (int i=0; i<=9434; i++){    //at first all locations are free
            waypoint_allowed[i]=true;
        }
    }
    
    void GetRandomWaypoint(){

    }

    void FreeWaypoint(){

    }
}
