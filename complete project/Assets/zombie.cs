using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie : MonoBehaviour
{
    //gets pathfinding agent of the object
    public NavMeshAgent nav;

    //gets player transform for pathfinding
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //assigns local pointer to player object
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //sets pathfinding destination to players transform
        nav.destination = player.transform.position;
    }
}
