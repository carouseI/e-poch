using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class NodeConnections : Node
{
    [SerializeField]
    protected float _connectivityRadius = 50f; //connection radius

    List<NodeConnections> _connections; //waypoint list

    // Start is called before the first frame update
    public void Start()
    {
        GameObject[] allNodes = GameObject.FindGameObjectsWithTag("Node"); //get all waypoint objects in scene

        _connections = new List<NodeConnections>(); //create list of waypoint refs

        for (int i = 0; i < allNodes.Length; i++)
        {
            NodeConnections nextNode = allNodes[i].GetComponent<NodeConnections>(); //check for connected waypoint

            if (nextNode != null) //if found + not null
            {
                if (Vector3.Distance(this.transform.position, nextNode.transform.position) <= _connectivityRadius && nextNode != this) //if distance between current + next waypoint, + does not equal this
                {
                    _connections.Add(nextNode); //add to current position
                }
            }
        }
    }
}