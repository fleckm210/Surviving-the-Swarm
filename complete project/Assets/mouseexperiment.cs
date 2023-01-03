using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mouseexperiment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    GameObject selectedObject;
    Ray ray;
    RaycastHit hitData;
    Plane plane = new Plane(Vector3.up, 0);
    bool objectclicked = false;
    int counter = 0;
    public Material mat1;
    public Material mat2;

    void Update()
    {
        counter++;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (objectclicked && counter > 10)
        {
            //imported code to convert mouse position to 3d space
            float distance;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (plane.Raycast(ray, out distance) && Input.GetMouseButton(0))
            {
                //sets pathfinding destination to mouse position if input receives left click
                selectedObject.GetComponent<NavMeshAgent>().destination = ray.GetPoint(distance);
            }
        }

        if (Physics.Raycast(ray, out hitData, 1000) && Input.GetMouseButtonDown(0) && objectclicked == false)
        {
            selectedObject = hitData.transform.gameObject;

            if (selectedObject.GetComponent<NavMeshAgent>() != null)
            {
                objectclicked = true;
                selectedObject.GetComponent<MeshRenderer>().material = mat1;
                counter = 0;
            }
        }

        if (Input.GetMouseButton(1))
        {
            selectedObject.GetComponent<MeshRenderer>().material = mat2;
            objectclicked = false;
        }
    }
}
