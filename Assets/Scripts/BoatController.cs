using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    #region wasd
    //[SerializeField] float speed;
    //[SerializeField] float rotationSpeed;

    //private Vector3 currentPosition;

    //// Update is called once per frame
    //void Update()
    //{
    //    Movement();
    //}

    //public void Movement()
    //{
    //    if (Input.GetKey(KeyCode.Z)) currentPosition.z += speed * Time.deltaTime; //w
    //    if (Input.GetKey(KeyCode.S)) currentPosition.z -= speed * Time.deltaTime; //s
    //    if (Input.GetKey(KeyCode.D)) currentPosition.x += speed * Time.deltaTime; //d
    //    if (Input.GetKey(KeyCode.Q)) currentPosition.x -= speed * Time.deltaTime; //a

    //    transform.position = currentPosition;
    //}

    //public void Rotation()
    //{
    //Vector3 targetDirection = Vector3.zero;

    //targetDirection.Normalize();
    //targetDirection.y = 0;

    //if (targetDirection == Vector3.zero)
    //    targetDirection = transform.forward;

    //Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
    //Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

    //transform.rotation = playerRotation;
    //}
    #endregion

    #region auto
    //[SerializeField] float moveSpeed = 1f;
    ////public static int moveSpeed = 1f;
    //public Vector3 boatDirection = Vector3.forward;

    //public void Update()
    //{
    //    transform.Translate(boatDirection * moveSpeed * Time.deltaTime);
    //}
    #endregion

    #region direct move
    //[SerializeField]
    //Transform _destination;

    //NavMeshAgent _navMeshAgent;

    //void Start()
    //{
    //    _navMeshAgent = this.GetComponent<NavMeshAgent>();

    //    if (_navMeshAgent == null)
    //    {
    //        Debug.LogError("navmeshagent comp not attached to " + gameObject.name);
    //    }
    //    else
    //    {
    //        SetDestination();
    //    }
    //}

    //private void SetDestination()
    //{
    //    if (_destination != null)
    //    {
    //        Vector3 targetVector = _destination.transform.position;
    //        _navMeshAgent.SetDestination(targetVector);
    //    }
    //}
    #endregion

    #region connected movement
    //[SerializeField] //dictates if agent waits on each node
    //bool _patrolWaiting;

    //[SerializeField] //total wait time @ each node
    //float _totalWaitTime = 3f;

    //[SerializeField] //probability of switching directions
    //float _switchProbability = 0.2f;

    ////private variables for base behaviour
    //NavMeshAgent _navMeshAgent;
    //ConnectedWaypoint _currentWaypoint;
    //ConnectedWaypoint _previousWaypoint;

    //bool _travelling;
    //bool _waiting;
    //float _waitTimer;
    //int _waypointsVisited;

    //// Start is called before the first frame update
    //public void Start()
    //{
    //    _navMeshAgent = this.GetComponent<NavMeshAgent>();

    //    if (_navMeshAgent == null)
    //    {
    //        Debug.LogError("nav mesh agent comp not attached to " + gameObject.name);
    //    }
    //    else
    //    {
    //        if (_currentWaypoint == null)
    //        {
    //            //set at random
    //            GameObject[] allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint"); //find all waypoints

    //            if (allWaypoints.Length > 0)
    //            {
    //                while (_currentWaypoint == null)
    //                {
    //                    int random = UnityEngine.Random.Range(0, allWaypoints.Length); //randomise
    //                    ConnectedWaypoint startingWaypoint = allWaypoints[random].GetComponent<ConnectedWaypoint>();

    //                    if (startingWaypoint != null) //if not null
    //                    {
    //                        _currentWaypoint = startingWaypoint; //set current to starting
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                Debug.LogError("failed to find useable waypoints"); //show msg
    //            }
    //        }

    //        SetDestination();
    //    }
    //}

    //private void Update()
    //{
    //    if (_travelling && _navMeshAgent.remainingDistance <= 1.0f) //if close to destination
    //    {
    //        _travelling = false;
    //        _waypointsVisited++;

    //        if (_patrolWaiting) //if going to wait
    //        {
    //            _waiting = true;
    //            _waitTimer = 0f;
    //        }
    //        else
    //        {
    //            SetDestination();
    //        }
    //    }

    //    if (_waiting) //if waiting
    //    {
    //        _waitTimer += Time.deltaTime;
    //        if (_waitTimer >= _totalWaitTime)
    //        {
    //            _waiting = false;

    //            SetDestination();
    //        }
    //    }
    //}

    //private void SetDestination()
    //{
    //    if (_waypointsVisited > 0)
    //    {
    //        //ConnectedWaypoint nextWaypoint = _currentWaypoint.NextWaypoint(_previousWaypoint);
    //        _previousWaypoint = _currentWaypoint;
    //        //_currentWaypoint = nextWaypoint;
    //    }

    //    Vector3 targetVector = _currentWaypoint.transform.position;
    //    _navMeshAgent.SetDestination(targetVector);
    //    _travelling = true;
    //}
    #endregion

    [SerializeField]
    protected float _connectivityRadius = 50f; //connection radius

    [SerializeField]
    List<Node> _nodes; //node list

    [SerializeField]
    public List<Node> _docks; //docks list

    public Transform nextNode;
    public Transform nextDock;
    public float moveSpeed;

    public int nextNodeIndex = 0;
    public bool isFinalNode = false; //set default to false

    public int nextDockIndex = 0;
    public bool isDocking = false; //set default to false
    public bool isInDockingRange;

    private void Start() //get node data
    {
        nextNode = _nodes[nextNodeIndex].transform; //get next node transform in index
        nextDock = _docks[nextDockIndex].transform; //get next dock transform in index
    }

    private void Update() //move based on node data
    {
        if (Input.GetKeyDown(KeyCode.E) && isInDockingRange == true) //if e is pressed + in range
        {
            isDocking = true; //dock
        }

        if(Vector3.Distance(transform.position, nextNode.position) <= 0.5f) //if distance between player + next node is less than .5
        {
            nextNodeIndex++; //increment
            nextNode = _nodes[nextNodeIndex].transform; //get attached object's transform

            if(nextNodeIndex == _nodes.Count) //count -- element num ref; 9th element = last
            {
                isFinalNode = true; //stop when final destination is reached
            }
        }
        if (!isFinalNode) //if destination is not reached + is docking
        {
            if (isDocking)
            {
                isMoving(nextDock); //move to next dock
            }
            else //if destination is not reached + is not docking
            {
                isMoving(nextNode); //move to next node
            }
        }
    }

    private void isMoving(Transform target)
    {
        Vector3 moveDir = target.position - this.transform.position; //move to next target
        moveDir = moveDir.normalized; //reset, mult by 1
        Vector3 changeInPos = moveDir * moveSpeed;

        changeInPos.y = 0; //exclude vertical movement

        this.transform.position += changeInPos;
        //this.transform.Rotate(Quaternion.FromToRotation(this.transform.forward, moveDir).eulerAngles); //calculate rotation
    }
}