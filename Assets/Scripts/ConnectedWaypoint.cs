using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ConnectedWaypoint : Waypoint
{
    [SerializeField]
    protected float _connectivityRadius = 50f; //connection radius

    List<ConnectedWaypoint> _connections; //waypoint list

    // Start is called before the first frame update
    public void Start()
    {
        GameObject[] allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint"); //get all waypoint objects in scene

        _connections = new List<ConnectedWaypoint>(); //create list of waypoint refs

        for (int i = 0; i < allWaypoints.Length; i++)
        {
            ConnectedWaypoint nextWaypoint = allWaypoints[i].GetComponent<ConnectedWaypoint>(); //check for connected waypoint

            if (nextWaypoint != null) //if found + not null
            {
                if (Vector3.Distance(this.transform.position, nextWaypoint.transform.position) <= _connectivityRadius && nextWaypoint != this) //if distance between current + next waypoint, + does not equal this
                {
                    _connections.Add(nextWaypoint); //add to current position
                }
            }
        }
    }
}