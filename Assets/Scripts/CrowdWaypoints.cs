using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrowdWaypoints : MonoBehaviour
{
    int array_size=9434;
    [SerializeField] private GameObject [] waypoints; //stores location where NPC are allowed to be
    private bool [] waypoint_allowed = new bool[9434];
    // Start is called before the first frame update
    void Start(){
        for (int i=0; i<array_size; i++){    //at first all locations are free
            waypoint_allowed[i]=true;
        }
    }
    
    public int GetRandomWaypoint(){
        int way_number=-1;

        /**
        First check will be in range of 0-200. If fails to find the number, will increment up to 20 times.
        Second check will be in range 200-1000. If fails to find the number, will increment up to 50 times.
        Third check will be in range 1000-4000. If fail to find the number, will increment up to 100 times.
        Forth check will be in range of 4000-9434. If fail to find number, will increment up to maximum.
        Last check, if no one was found, then will increment from 0 to max. There will always be more waypoints spots compared to NPC.
        **/
        
        way_number=RandomChecker(0,200,2);

        if(way_number==-1){
            way_number=RandomChecker(200,1000,5);
        }
        if(way_number==-1){
            way_number=RandomChecker(1000,4000,10);
        }
        if(way_number==-1){
            way_number=RandomChecker(4000,array_size,100);
        }
        if(way_number==-1){
            way_number=RandomChecker(0,array_size,array_size);
        }
        
        return way_number;
    }

    private int RandomChecker(int min_range, int max_range, int increment_number){
        int return_value = -1; //-1 means that didnt find
        int randomNumber = UnityEngine.Random.Range(min_range,max_range);
        if (array_size==increment_number){//special case scenario, where we didnt find any free spot with first 4 tries
            randomNumber=0;
        }
        for (int i =0; i<increment_number; i++){
            if (randomNumber+i>=array_size){
                break;
            }
            if(waypoint_allowed[randomNumber+i]){
                waypoint_allowed[randomNumber+i]=false;//book this spot
                return_value=randomNumber+i;
                break;
            }
        }
        return return_value;
    }

    public Vector3 GetWaypointCoordinates(int way_number){
        return waypoints[way_number].transform.position;
    }

    public void FreeWaypoint(int way_number){
        waypoint_allowed[way_number]=true;
    }

    public bool CheckWaypoint(int way_number){  //pass the number you want to check
        if (waypoint_allowed[way_number]){
            return true;
        }
        else{
            return false;
        }
    }
}
